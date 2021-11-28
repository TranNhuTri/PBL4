using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private TcpListener listener = new TcpListener(IPAddress.Any, 1308);
        internal static Dictionary<string, Client> clients;
        public Server()
        {
            clients = new Dictionary<string, Client>();
            listener.Start();
        }
        public void Start()
        {
            while(true)
            {
                var TcpClient = listener.AcceptTcpClient();
                var client = new Client(TcpClient);
                clients.Add(client.IP, client);
                Thread thread = new Thread(client.Run);
                thread.Start();
                string data = Server.getAllClientInfors();
                Server.sendToAllClients(data);
            }
        }
        public static string getAllClientInfors()
        {
            var res = "";
            foreach (var key in Server.clients.Keys)
            {
                res = res + Server.clients[key].name + "," + key + " ";
            }
            if(!string.IsNullOrEmpty(res))
            {
                res = res.Substring(0, res.Length - 1);
            }
            return res;
        }
        public static void sendToAllClients(string data)
        {
            foreach (var key in Server.clients.Keys)
            {
                Server.clients[key].writer.WriteLine(data);
            }
        }
    }
}
