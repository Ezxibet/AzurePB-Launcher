using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Launcher
{
    internal class Config
    {
        public static string URL, usrAgent, Ver;

        static Config()
        {
            URL = "http://localhost/";
            Ver = @"\config.zpt";
            usrAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36";
        }
        public static void Logger(string texto)
        {
            _ = DateTime.Now;
            StreamWriter streamWriter = new StreamWriter("PBLauncher.log", true);
            if (texto == null)
            {
                texto = " ";
            }
            else
            {
                texto = texto + " - " + DateTime.Now.ToString();
            };
            streamWriter.WriteLine(texto);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}