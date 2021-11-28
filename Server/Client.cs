using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Client
    {
        private TcpClient client { get; set; }
        public string name { get; set; }
        public string IP { get; set; }
        public StreamReader reader;
        public StreamWriter writer;
        public Client(TcpClient client)
        {
            this.client = client;
            var stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream) { AutoFlush = true };

            var clientName = reader.ReadLine();

            Console.WriteLine(clientName);

            this.name = clientName;
            this.IP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
        }

        public async void Run()
        {
            while(true)
            {
                try
                {
                    if(!client.Connected)
                    {
                        Server.clients.Remove(this.IP);
                        break;
                    }    
                    string str = await reader.ReadLineAsync();
                    Console.WriteLine("Recieve " + str);
                    if (str == null)
                    {
                        Server.clients.Remove(this.IP);
                        break;
                    }    
                    string[] request = str.Split(' ');
                    string type = request[0];
                    string objectType = request[1];

                    switch(type)
                    {
                        case "get":
                            switch (objectType)
                            {
                                case "disk-drives":
                                    Server.clients[request[2]].writer.WriteLine("get disk-drives " + this.IP);
                                    break;
                                case "disk-drive-infor":
                                    Console.WriteLine(request[2]);
                                    break;
                            }
                            break;
                        case "post":
                            switch (objectType)
                            {
                                case "disk-drives":
                                    var destinationName = request[2];
                                    Server.clients[destinationName].writer.WriteLine("res disk-drives " + request[3]);
                                    break;
                            }
                            break;

                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }
            }
        }
    }
}
