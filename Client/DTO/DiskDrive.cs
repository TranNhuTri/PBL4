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
        public ICollection<LogicalDisk> logicalDisks { get; set; }
        public DiskDrive()
        {
            logicalDisks = new List<LogicalDisk>();
        }
        public DiskDrive(string dataStr)
        {
            var data = dataStr.Split('@');
            var diskDriveInfor = data[0].Split(',');
            Name = diskDriveInfor[0];
            Producer = diskDriveInfor[1];
            ProdutCode = diskDriveInfor[2];
            SerialNumber = diskDriveInfor[3];
            MediaType = diskDriveInfor[4];
            Status = diskDriveInfor[5];
            Space = Convert.ToInt64(diskDriveInfor[6]);
            FreeSpace = Convert.ToInt64(diskDriveInfor[7]);
            TotalSector = Convert.ToInt64(diskDriveInfor[8]);
            TotalCylinder = Convert.ToInt64(diskDriveInfor[9]);
            SectorsPerTrack = Convert.ToInt64(diskDriveInfor[10]);
            TracksPerCynlinder = Convert.ToInt64(diskDriveInfor[11]);
            BytesPerSector = Convert.ToInt64(diskDriveInfor[12]);

            var logicalDiskInfors = data[1].Split(',');
            logicalDisks = new List<LogicalDisk>();
            foreach(var diskInfor in logicalDiskInfors)
            {
                logicalDisks.Add(new LogicalDisk(diskInfor));
            }
        }
        public override string ToString()
        {
            var logicalDisks = "";
            foreach(var item in this.logicalDisks)
            {
                logicalDisks = logicalDisks + item.ToString() + ",";
            }
            logicalDisks = logicalDisks.Substring(0, logicalDisks.Length - 1);

            return this.Name.Replace(' ', '_') + "," + this.Producer.Replace(' ', '_') + "," + this.ProdutCode.Replace(' ', '_') + "," +  this.SerialNumber.Replace(' ', '_') + ","
                + this.MediaType.Replace(' ', '_') + "," + this.Status.Replace(' ', '_') + "," + this.Space + "," + this.FreeSpace + "," + this.TotalSector
                + "," + this.TotalCylinder + "," + this.SectorsPerTrack + "," + this.TracksPerCynlinder + "," + this.BytesPerSector + "@" + logicalDisks;
        }
    }
}
