using Client.DTO;
using Client.Services;
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
        private IPAddress serverIP = IPAddress.Parse("192.168.1.8");
        private TcpClient client = new TcpClient();
        private StreamWriter writer;
        private StreamReader reader;
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
                        switch(objectType)
                        {
                            case "disk-drives":
                                var post = "post disk-drives " + res[2] + " ";
                                var diskDriveQuery = new ManagementObjectSearcher("select * from Win32_DiskDrive");
                                foreach (var item in diskDriveQuery.Get())
                                {
                                    post = post + item.Properties["Name"].Value.ToString().Substring(4) + ",";
                                }
                                post = post.Substring(0, post.Length - 1);
                                writer.WriteLine(post);
                                break;
                            case "disk-drive-infor":
                                var diskDrive = Service.Instance.GetDiskDriveInfor(res[2]);
                                MessageBox.Show(diskDrive.ToString());
                                break;
                        }    
                        break;
                    case "post":
                        break;
                    case "res":
                        switch (objectType)
                        {
                            case "disk-drives":
                                var data = res[2].Split(',');
                                foreach (var item in data)
                                {
                                    disk_drive_cbb.Items.Add(item);
                                }
                                break;
                        }
                        break;
                    default:
                        machine_cbb.Items.Clear();
                        machine_cbb.Items.Add("This PC");

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

        private void machine_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(machine_cbb.SelectedIndex != 0)
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
