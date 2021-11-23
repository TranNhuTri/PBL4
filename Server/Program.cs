using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> clients = new Dictionary<string, string>();

            var listener = new TcpListener(IPAddress.Any, 1308);
            listener.Start(10);

            while (true)
            {
                var client = listener.AcceptTcpClient();
                var stream = client.GetStream();

                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream) { AutoFlush = true };

                var clientName = reader.ReadLine();

                var clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                clients[clientIP] = clientName;

                var response = "";
                foreach (var key in clients.Keys)
                {
                    response = response + key + '/' + clients[key] + ' ';
                }

                Console.WriteLine(response);

                writer.WriteLine(response);
                client.Close();
            }
        }
    }
}