using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace i3BaseUp
{
    public class Config
    {
        public static string STATUS, FILE, TOTAL, LEAVE_LAUNCHER, LAUNCHER_VERSION, VERSION, GAME_UDATE, LAUNCHER_READY, CHECK_FILES, DOWNLOADING, UNZIP_FILE,
        DOWNLOAD_READY, URL, USERAGENT;
        public static void LanguagePTBR()
        {
            STATUS = "Você pode iniciar o jogo.";
            FILE = "File";
            TOTAL = "Total";
            LEAVE_LAUNCHER = "Você tem certeza que deseja sair?";
            VERSION = "Versão: ";
            LAUNCHER_VERSION = "Versão do launcher: ";
            GAME_UDATE = "Nova versão do Jogo disponível.";
            LAUNCHER_READY = "Você pode iniciar o jogo.";
            CHECK_FILES = "Check";
            DOWNLOADING = "Iniciando download...";
            UNZIP_FILE = "Extraindo arquivos....";
            DOWNLOAD_READY = "Fim do patch. Já pode jogar.";
            URL = "https://cheaters.pro/ac-status";
            USERAGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36";
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
                texto += " ";
            };
            streamWriter.WriteLine(texto);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
