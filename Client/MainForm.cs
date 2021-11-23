using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        private readonly IPAddress _serverIP;
        private readonly string _clientName;
        public MainForm()
        {
            InitializeComponent();
            _serverIP = IPAddress.Parse("127.0.0.1");
            _clientName = System.Environment.MachineName;
            SetCbb();
        }

        private string Request(string request)
        {
            var client = new TcpClient();
            client.Connect(_serverIP, 1308);

            var stream = client.GetStream();
            var writer = new StreamWriter(stream) { AutoFlush = true };
            var reader = new StreamReader(stream);

            writer.WriteLine(request);
            var response = reader.ReadLine();
            client.Close();

            return response;
        }

        private void SetCbb()
        {
            var response = Request(_clientName);
            foreach(var item in response.Split(' '))
            {
                if(item != "")
                {
                    var inforClient = item.Split('/');
                    cbbDeviceName.Items.Add(inforClient[1]);
                }
            }
        }
    }
}
