using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace WindRider
{
    class Tester
    {
        public const int SHORT_TRANSFERS = 10;
        public int[] TESTING_PORT = {21, 53, 80, 4662};

        public string[] TESTING_SERVER = { "165.124.182.187" , "165.124.182.187"};

        public double test()
        {
            string outputString;
            double[][] arrayMeasured = new double[3][];

            for (int i = 0; i < 3; i++)
            {
                arrayMeasured[i] = new double[SHORT_TRANSFERS + 1];
            }

            TcpClient socketForServer;
            try
            {
                Random randNum = new Random();

                socketForServer = new TcpClient(TESTING_SERVER[randNum.Next(TESTING_SERVER.Length)], TESTING_PORT[randNum.Next(TESTING_PORT.Length)]);
            }
            catch
            {
                Console.WriteLine("Failed to connect to server at {0}:80", "localhost");
                return 0;
            }

            NetworkStream networkStream = socketForServer.GetStream();
            System.IO.StreamReader streamReader =
            new System.IO.StreamReader(networkStream);
            System.IO.StreamWriter streamWriter =
            new System.IO.StreamWriter(networkStream);

            try
            {
                for (int i = 0; i < SHORT_TRANSFERS; i++)
                {
                    arrayMeasured[0][i] = (double)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
                    outputString = streamReader.ReadLine();
                    arrayMeasured[1][i] = (double)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
                    streamWriter.WriteLine(outputString);
                    arrayMeasured[2][i] = (double)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
                    streamWriter.Flush();
                }

                arrayMeasured[0][SHORT_TRANSFERS] = (double)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
                outputString = streamReader.ReadLine();
                arrayMeasured[1][SHORT_TRANSFERS] = (double)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
                streamWriter.WriteLine(outputString);
                arrayMeasured[2][SHORT_TRANSFERS] = (double)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
                streamWriter.Flush();

                streamWriter.WriteLine(FormTesting.hash + '|' + FormTesting.zipCode + '|' + FormTesting.provider + '|');
                streamWriter.Flush();

                for (int i = 0; i <= SHORT_TRANSFERS; i++)
                {
                    streamWriter.WriteLine(arrayMeasured[0][i].ToString() + '|' + arrayMeasured[1][i].ToString() + '|' + arrayMeasured[2][i].ToString());
                    streamWriter.Flush();
                }
            }

            catch
            {
                Console.WriteLine("Exception sending to Server");
            }
            networkStream.Close();

            if (arrayMeasured[0][SHORT_TRANSFERS] != arrayMeasured[2][SHORT_TRANSFERS])
            {
                return 200000.0 /(arrayMeasured[2][SHORT_TRANSFERS] - arrayMeasured[0][SHORT_TRANSFERS]);
            }
            else
            {
                return 0;
            }
        }
    }
}
