using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DTO
{
    public class LogicalDisk
    {
        public string Name { get; set; }
        public string FileSystem { get; set; }
        public long Space { get; set; }
        public long FreeSpace { get; set; }
        public long SectorsPerCluster { get; set; }
        public LogicalDisk()
        {
        }
        public LogicalDisk(string dataStr)
        {
            var data = dataStr.Split('/');
            Name = data[0];
            FileSystem = data[1];
            Space = Convert.ToInt64(data[2]);
            FreeSpace = Convert.ToInt64(data[3]);
            SectorsPerCluster = Convert.ToInt64(data[4]);
        }
        public override string ToString()
        {
            return this.Name + "/" + this.FileSystem + "/" + this.Space + "/" + this.FreeSpace + "/" + this.SectorsPerCluster;
        }
    }
}
