using Client.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    public class Service
    {
        private static Service _Instance;
        public static Service Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Service();
                return _Instance;
            }
            set { }
        }
        private Service() { }
        public DiskDrive GetDiskDriveInfor(string physicalDrive)
        {
            DiskDrive diskDrive = new DiskDrive();

            var freeSizeOfDisk = 0.0;
            var physicalDriveRelativePath = string.Format("Win32_DiskDrive.DeviceID=\"\\\\\\\\.\\\\{0}\"", physicalDrive);
            var partitionQueryText = string.Format("associators of {{{0}}} where AssocClass = Win32_DiskDriveToDiskPartition", physicalDriveRelativePath);
            var partitionQuery = new ManagementObjectSearcher(partitionQueryText);

            foreach (var p in partitionQuery.Get())
            {
                var indexOfStartPartionPath = p.ToString().IndexOf("Win32_DiskPartition");
                var partionRelativePath = p.ToString().Substring(indexOfStartPartionPath);
                var logicalDriveQueryText = string.Format("associators of {{{0}}} where AssocClass = Win32_LogicalDiskToPartition", partionRelativePath);
                var logicalDriveQuery = new ManagementObjectSearcher(logicalDriveQueryText);

                foreach (var ld in logicalDriveQuery.Get())
                {
                    freeSizeOfDisk += Math.Round((Convert.ToUInt64(ld.Properties["FreeSpace"].Value) / Math.Pow(1024, 3)), 0, MidpointRounding.AwayFromZero);
                }
            }
            diskDrive.FreeSpace = Convert.ToInt32(freeSizeOfDisk);

            var physicalDriveQuery = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            //
            //get name of disk drive 
            //
            foreach (var d in physicalDriveQuery.Get())
            {

                if (physicalDrive == d.Properties["Name"].Value.ToString().Substring(4))
                {
                    diskDrive.Name = d.Properties["Modal"].Value.ToString();
                    diskDrive.Producer = d.Properties["Caption"].Value.ToString().Split(' ')[0];
                    //diskDrive.ProdutCode = d.Properties["Caption"].Value.ToString().Split(' ')[1];
                    diskDrive.SerialNumber = d.Properties["SerialNumber"].Value.ToString().Trim();
                    diskDrive.MediaType = d.Properties["MediaType"].Value.ToString();
                    diskDrive.Space = Convert.ToInt32(Math.Round((Convert.ToUInt64(d.Properties["Size"].Value) / Math.Pow(1024, 3)), 0, MidpointRounding.AwayFromZero).ToString());
                    diskDrive.Status = d.Properties["Status"].Value.ToString();

                    var size = Convert.ToInt64(d.Properties["Size"].Value);
                    var totalCylinders = Convert.ToInt64(d.Properties["TotalCylinders"].Value);
                    var totalSectors = Convert.ToInt64(d.Properties["TotalSectors"].Value);
                    var tracksPerCylinder = Convert.ToInt64(d.Properties["TracksPerCylinder"].Value);
                    var sectorsPerTrack = Convert.ToInt64(d.Properties["SectorsPerTrack"].Value);

                    diskDrive.TotalSector = totalSectors;
                    diskDrive.SectorsPerTrack = sectorsPerTrack;
                    diskDrive.TracksPerCynlinder = tracksPerCylinder;
                    diskDrive.TotalCylinder = totalCylinders;
                    //
                    //determine bytes in each sector
                    //bytePerSector = size / (the total number of cylinders * tracks in each cylinder * sectors in each track)
                    //
                    var bytePerSector = size / (totalCylinders * tracksPerCylinder * sectorsPerTrack);
                    diskDrive.BytesPerSector = bytePerSector;

                }
            }
            return diskDrive;
        }
    }
}
