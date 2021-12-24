using Client.DTO;
using Client.Services;
using Client.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        private IPAddress serverIP = IPAddress.Parse("192.168.1.3");
        private TcpClient client = new TcpClient();
        private StreamWriter writer;
        private StreamReader reader;
        private DiskDrive diskDrive;
        public MainForm()
        {
            InitializeComponent();
            client.Connect(serverIP, 1308);
            var stream = client.GetStream();
            writer = new StreamWriter(stream) { AutoFlush = true };
            reader = new StreamReader(stream);
            writer.WriteLine(System.Environment.MachineName);
        }
        public async Task Handle()
        {
            while(true)
            {
                var res = (await reader.ReadLineAsync()).Split(' ');
                string type = res[0];
                string objectType = res.Length > 1 ? res[1] : null;

                switch (type)
                {
                    case "get":
                        var destinationIP = res[res.Length - 1];
                        switch(objectType)
                        {
                            case "disk-drives":
                                {
                                    var post = "post disk-drives ";
                                    var diskDriveQuery = new ManagementObjectSearcher("select * from Win32_DiskDrive");
                                    foreach (var item in diskDriveQuery.Get())
                                    {
                                        post = post + item.Properties["Name"].Value.ToString().Substring(4) + ",";
                                    }
                                    post = post.Substring(0, post.Length - 1) + " " + destinationIP;
                                    writer.WriteLine(post);
                                    break;
                                }
                            case "disk-drive-infor":
                                {
                                    var diskDrive = Service.Instance.GetDiskDriveInfor(res[2]);
                                    var post = "post disk-drive-infor " + diskDrive.ToString() + " " + destinationIP;
                                    writer.WriteLine(post);
                                    break;
                                }
                        }    
                        break;
                    case "post":
                        break;
                    case "res":
                        switch (objectType)
                        {
                            case "disk-drives":
                                {
                                    disk_drive_cbb.Items.Clear();
                                    var data = res[2].Split(',');
                                    foreach (var item in data)
                                    {
                                        disk_drive_cbb.Items.Add(item);
                                    }
                                    break;
                                }
                            case "disk-drive-infor":
                                {
                                    this.diskDrive = new DiskDrive(res[2]);
                                    SetGUI(diskDrive);
                                    break;
                                }
                        }
                        break;
                    default:
                        machine_cbb.Items.Clear();

                        foreach (var item in res)
                        {
                            string[] clientInfor = item.Split(',');
                            string name = clientInfor[0];
                            string IP = clientInfor[1];

                            if(name.Equals(System.Environment.MachineName))
                            {
                                continue;
                            }
                            machine_cbb.Items.Add(new CbbItem() 
                            { 
                                Name = name,
                                IP = IP
                            });
                        }
                        break;
                }
            }
        }
        public void RemoveLabelAndProgressBar()
        {

            List<Label> labels = panel.Controls.OfType<Label>().ToList();
            List<ProgressBar> progressBars = panel.Controls.OfType<ProgressBar>().ToList();

            foreach (Label lb in labels)
            {
                lb.Click -= new EventHandler(this.dynamicLabel_Click);
                panel.Controls.Remove(lb);
                lb.Dispose();
            }

            foreach (ProgressBar pgb in progressBars)
            {
                panel.Controls.Remove(pgb);
                pgb.Dispose();
            }
        }
        private void dynamicLabel_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            string nameOfLogicalDisk = lb.Text;
            LogicalDisk logicalDisk = null;
            foreach(var item in this.diskDrive.logicalDisks)
            {
                if(item.Name == nameOfLogicalDisk)
                {
                    logicalDisk = item;
                    break;
                }
            }    
            DetailForm f = new DetailForm(logicalDisk);
            f.Show();
        }
        private void SetGUI(DiskDrive diskDrive)
        {
            disk_drive_name_txt.Text = diskDrive.Name;
            producer_txt.Text = diskDrive.Producer;
            product_code_txt.Text = diskDrive.ProdutCode;
            serial_number_txt.Text = diskDrive.SerialNumber;
            media_type_txt.Text = diskDrive.MediaType;
            total_sector_txt.Text = diskDrive.TotalSector.ToString();
            space_txt.Text = diskDrive.Space.ToString() + " GB";
            free_space_txt.Text = diskDrive.FreeSpace.ToString() + " GB";
            status_txt.Text = diskDrive.Status;
            sectors_per_track_txt.Text = diskDrive.SectorsPerTrack.ToString();
            tracks_per_cylinder_txt.Text = diskDrive.TracksPerCynlinder.ToString();
            total_cylinder_txt.Text = diskDrive.TotalCylinder.ToString();
            bytes_per_sector_txt.Text = diskDrive.BytesPerSector.ToString();

            int tmpX = 0, tmpY = 0, locationX = 30;
            foreach (var logicalDisk in diskDrive.logicalDisks)
            {
                var dynamicLabel = new Label();
                dynamicLabel.Height = 21;
                dynamicLabel.Width = 21;
                dynamicLabel.Text = logicalDisk.Name;
                dynamicLabel.Click += dynamicLabel_Click;

                var dynamicLabel_2 = new Label();
                dynamicLabel_2.Height = 20;
                dynamicLabel_2.Width = 170;
                dynamicLabel_2.Text = logicalDisk.FreeSpace.ToString() + " GB free of " + logicalDisk.Space.ToString() + " GB";

                var dynamicProgressBar = new ProgressBar();
                dynamicProgressBar.Height = 20;
                dynamicProgressBar.Width = 240;
                dynamicProgressBar.Minimum = 0;
                dynamicProgressBar.Maximum = 100;
                dynamicProgressBar.Value = (int)((logicalDisk.Space - logicalDisk.FreeSpace)*1.0/logicalDisk.Space * 100);

                var temp = tmpX + locationX + dynamicProgressBar.Width + dynamicLabel.Width;

                if (temp > this.panel.Width)
                {
                    tmpY += dynamicLabel.Height + dynamicProgressBar.Height + dynamicLabel_2.Height;
                    tmpX = 0;

                    dynamicLabel.Location = new Point(tmpX, tmpY + 4);
                    dynamicLabel_2.Location = new Point(tmpX, tmpY + dynamicLabel.Height + 4);
                    dynamicProgressBar.Location = new Point(tmpX + dynamicLabel.Width, tmpY);

                    tmpX = locationX + dynamicProgressBar.Width + dynamicLabel.Width;
                }
                else
                {
                    dynamicLabel.Location = new Point(tmpX, tmpY + 4);
                    dynamicLabel_2.Location = new Point(tmpX, tmpY + dynamicLabel.Height + 4);
                    dynamicProgressBar.Location = new Point(tmpX + dynamicLabel.Width, tmpY);

                    tmpX += locationX + dynamicProgressBar.Width + dynamicLabel.Width;
                }

                panel.Controls.Add(dynamicProgressBar);
                panel.Controls.Add(dynamicLabel);
                panel.Controls.Add(dynamicLabel_2);
            }
        }
        private void machine_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(machine_cbb.SelectedIndex != -1)
            {
                string request = "get disk-drives " + ((CbbItem)machine_cbb.SelectedItem).IP;
                writer.WriteLine(request);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

        private void show_infor_disk_drive_btn_Click(object sender, EventArgs e)
        {
            if(disk_drive_cbb.SelectedIndex >= 0)
            {
                string request = "get disk-drive-infor " + ((CbbItem)machine_cbb.SelectedItem).IP + " " + disk_drive_cbb.SelectedItem;
                writer.WriteLine(request);
            }    
        }
    }
}
