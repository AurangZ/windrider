using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace WindRider
{
    class Sender
    {
        public const string TESTING_SERVER = "165.124.182.187";
        public const int TESTING_PORT = 2000;

        public void send(string outputString)
            {
                TcpClient socketForServer;
                try
                {
                    socketForServer = new TcpClient(TESTING_SERVER, TESTING_PORT);
                }
                catch
                {
                    Console.WriteLine("Failed to connect to server at {0}:80", "localhost");
                    return;
                }
                NetworkStream networkStream = socketForServer.GetStream();
                System.IO.StreamReader streamReader =
                new System.IO.StreamReader(networkStream);
                System.IO.StreamWriter streamWriter =
                new System.IO.StreamWriter(networkStream);
                try
                {
                     streamWriter.WriteLine(outputString);
                     streamWriter.Flush();
                }
                catch
                {
                    Console.WriteLine("Exception sending to Server");
                }
                networkStream.Close();
            }
    }

}
