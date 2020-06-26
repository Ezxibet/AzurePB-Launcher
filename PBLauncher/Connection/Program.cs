using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Connection
{
    class Program
    {
        private const int SERVER_PORT = 2345;
        static int Main()
        {
            bool done = false;
            var listener = new TcpListener(IPAddress.Any, SERVER_PORT);
            listener.Start();
            Console.Title = ("PBLauncher AUTH");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" AUTH do PBLauncher está ativo..");
            while (!done)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" PBLauncher conectado na porta: " + SERVER_PORT);
                _ = client.Client;
                NetworkStream nstream = client.GetStream();
                byte[] byteTime = Encoding.ASCII.GetBytes(DateTime.Now.ToString());
                try
                {
                    nstream.Write(byteTime, 0, byteTime.Length);
                    try
                    {
                        nstream.Close();
                        client.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("SocketException: {0}", e);
                }
            }
            listener.Stop();
            return 0;
        }
    }
}
