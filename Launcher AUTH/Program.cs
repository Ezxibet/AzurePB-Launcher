using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Launcher_AUTH
{
    class Program
    {
        private static Socket server;
        public static string host = "54.39.81.71";
        public static string LauncherToken = "0000";
        public static int port = 25009;

        private static DateTime GetLinkerTime(Assembly assembly, TimeZoneInfo target = null)
        {
            var filePath = assembly.Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;
            var buffer = new byte[2048];
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            stream.Read(buffer, 0, 2048);
            var offset = BitConverter.ToInt32(buffer, c_PeHeaderOffset);
            var secondsSince1970 = BitConverter.ToInt32(buffer, offset + c_LinkerTimestampOffset);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return TimeZoneInfo.ConvertTimeFromUtc(epoch.AddSeconds(secondsSince1970), target ?? TimeZoneInfo.Local);
        }
        protected static void Main()
        {
            _ = GetLinkerTime(Assembly.GetExecutingAssembly(), null).ToString("dd/MM/yyyy HH:mm");
            Logger.CheckDirectory();
            Console.Title = "[SERVER] LAUNCHER AUTH - XENON PROTECT PBLAUNCHER";
            Logger.Info("________________________________________________________________________________");
            Logger.Info("                                                                                ");
            Logger.Info("                                                                                ");
            Logger.Info("                              SERVER LAUNCHER AUTH                              ");
            Logger.Info("              [SERVER] LAUNCHER AUTH - XENON PROTECT PBLAUNCHER                 ");
            Logger.Info("                                                                                ");
            Logger.Info("________________________________________________________________________________");
            Logger.Info(null);
            Logger.Warning("[AUTH] Iniciando o Launcher AUTH...");
            Logger.Warning("[AUTH] Launcher ativo em: " + host + " : "+ port);
            Logger.Warning("[TOKEN] PBLauncher Token: " + LauncherToken);
            bool check = true;
            if (check)
            {
                Start();
                Logger.Warning(StartSuccess());
                Memoria();
            }
            Process.GetCurrentProcess().WaitForExit();
        }

        private static string StartSuccess()
        {
            return "[AUTH] Servidor online [" + DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "]";
        }

        public static async void Memoria()
        {
            while (true)
            {
                try
                {
                    Console.Title = "Launcher AUTH [Memória usada: " + (GC.GetTotalMemory(true) / 1024) + " KB]";
                    Socket Packet = server.Accept();
                    byte[] buffer;
                    buffer = new byte[1024];
                    int rec = Packet.Receive(buffer, 0, buffer.Length, 0);
                    Array.Resize(ref buffer, rec);
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                await Task.Delay(1000);
            }
        }
        public static bool Start()
        {
            try
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint Local = new IPEndPoint(IPAddress.Parse(host), port);
                server.Bind(Local);
                server.Listen((int)SocketOptionName.MaxConnections);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string SendReportRequest(string url, string token)
        {
            CookieContainer Cookie = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "PBLauncher";
            request.CookieContainer = Cookie; // use the global cookie variable
            string postData = "token=" + token;
            byte[] data = Encoding.UTF8.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            WebResponse response = (HttpWebResponse)request.GetResponse();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }
}
