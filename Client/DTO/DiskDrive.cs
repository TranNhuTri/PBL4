using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DTO
{
    public class DiskDrive
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public string ProdutCode { get; set; }
        public string SerialNumber { get; set; }
        public string MediaType { get; set; }
        public string Status { get; set; }
        public long Space { get; set; }
        public long FreeSpace { get; set; }
        public long TotalSector { get; set; }
        public long TotalCylinder { get; set; }
        public long SectorsPerTrack { get; set; }
        public long TracksPerCynlinder { get; set; }
        public long BytesPerSector { get; set; }
        public override string ToString()
        {
            return this.Name + "," + this.Producer + "," + this.ProdutCode + "," + this.SerialNumber + ","
                + this.MediaType + "," + this.Status + "," + this.Space + "," + this.FreeSpace + "," + this.TotalSector
                + "," + this.TotalCylinder + "," + this.SectorsPerTrack + "," + this.TracksPerCynlinder + "," + this.BytesPerSector;
        }
    }
}
