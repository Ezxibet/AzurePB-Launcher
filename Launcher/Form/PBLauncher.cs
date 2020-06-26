
using PBLauncher.Properties;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using i3BaseUp;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Launcher
{
    public partial class PBLauncher : Form
    {
        public WebClient GameUpdate = new WebClient();
        public int lastVersion = -1;
        public bool loadingVerif;
        private Point Ponto;
        public PBLauncher()
        {
            InitializeComponent();
            GameUpdate.DownloadFileCompleted += new AsyncCompletedEventHandler(GameUpdate_DownloadCompleted);
            GameUpdate.DownloadProgressChanged += new DownloadProgressChangedEventHandler(GameUpdate_DownloadProgressChanged);
        }

        public PBLauncher(String playertoken)
        {
            InitializeComponent();
            Ptoken.Text = playertoken;
           
        }
        public void Bar1SetProgress(long received, long maximum, bool v)
        {
            ArchiveBar.Width = (int)(received * 463 / maximum);
        }
        public void Bar2SetProgress(ulong received, ulong maximum)
        {
            TotalBar.Width = (int)(received * 463 / maximum);
        }
        public void Buttons_Enable(bool Iniciar, bool Verificar, bool Update)
        {
            Start.Enabled = Iniciar;
            Verif.Enabled = Verificar;
            Button_Update.Enabled = Update;
        }
        public void Buttons_Visible(bool Iniciar, bool Verificar, bool Update)
        {
            Start.Visible = Iniciar;
            Verif.Visible = Verificar;
            Button_Update.Visible = Update;
        }
        private void GameUpdate_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                int num = + 1;
                File.ReadAllText(string.Concat(Application.StartupPath, "\\Config.zpt"));
                ArchiveBar.Width = 0;
                object[] actualVersion = new object[] { Application.StartupPath, "\\Patch\\Patch_", num, ".zip" };
                Unzip(Application.StartupPath, string.Concat(actualVersion));
                Directory.Delete(string.Concat(Application.StartupPath, "\\Patch"), true);
                Buttons_Visible(true, true, false);
                Buttons_Enable(true, true, false);
                ArchiveBar.Width = 463;
                total_label.Visible = false;
            }
        }
        private void GameUpdate_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Bar2SetProgress((ulong)e.BytesReceived, (ulong)e.TotalBytesToReceive);
            total_label.Text = string.Concat(new string[] { "Baixados: ", (e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), " MB de ", (e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"), " MB" });
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = true)]
        public static extern bool GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int size, string lpFileName);

        protected int onDownloadingFileId = 0;
        protected JObject jsonFiles;


        
    string currentPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory());
    

    public void Launcher_Load(object sender, EventArgs e)
        {

        //    Ptoken.Text = Connect.txxtSenha.Text;


            lblstatus.Text = "Você pode iniciar o jogo.";
            total_label.Visible = false;
            Sair.Visible = false;

            textBoxSavePath.Text = (Application.StartupPath);

            int filesOK = 0;
            WebClient webClient = new WebClient();
            string Request = webClient.DownloadString("http://54.39.81.71/pblauncher/files.json");

            jsonFiles = JObject.Parse(Request);

            for (int i = 1; i <= jsonFiles["files"].Count(); i++)
            {
              //  MessageBox.Show("verificando");
                string curFileOutDir = textBoxSavePath.Text + @"\" + jsonFiles["files"]["file" + i]["name"];
                int curFileSize = Convert.ToInt32(jsonFiles["files"]["file" + i]["size"]);
                string curFileName = jsonFiles["files"]["file" + i]["name"].ToString();

                if (File.Exists(curFileOutDir) && curFileSize == new FileInfo(curFileOutDir).Length)
                    filesOK++;
             //   MessageBox.Show("ta ok");
            }

            if (filesOK >= jsonFiles["files"].Count())
                lblstatus.Text = "Você pode iniciar o jogo.";

            else

          //  Jogar.Enabled = false;
          //  Veri.Enabled = false;
            AttDetect.Visible = true;
         //   Jogar.Enabled = false;
          //    Veri.Enabled = false;
            // timerDownload.Start();





            //WebClient web2 = new WebClient();
            //string Dados = web2.DownloadString("https://projectnightclub.buzz/launcher/last_client_version.txt");

            //if (Dados == "0")
            //{
            //    //  MessageBox.Show("Sem att");
            //    //Buttons_Visible(true, true, false);
            //    //Buttons_Enable(true, true, false);
            ////    lblstatus.Text = "Você pode iniciar o jogo.";
            //  //  Start.BackgroundImage = Resources.Start_Normal;
            //    // lblstatus.Text = Config.STATUS;
            //    //    System.Environment.Exit(0);
            //}
            //else if (Dados != "14")
            //{
            //    //  MessageBox.Show("Atualização");
            //    //  Process.Start("https://cheaters.pro/index.php");
            //    // Verif.BackgroundImage = Resources.Check_Disable;
            //    // Start.BackgroundImage = Resources.Update_Normal;
            //  //  Start.Enabled = false;

            //  //  lblstatus.Text = "Nova versão do Jogo disponível.";
            //   // lblstatus.Text = Config.GAME_UDATE;
            //    //   System.Environment.Exit(0);
            //}



            int num = +1;
            Config.LanguagePTBR();
            Config.Logger("[PB] PBLauncher iniciado >>>");
            
            //lblfile.Text = Config.FILE;
            //lbltotal.Text = Config.TOTAL;
            Visible = true;
            //lastVersion = int.Parse(GameUpdate.DownloadString(string.Concat(Config.URL + "/ac-status/last_client_version.txt")));
            //int.Parse(GameUpdate.DownloadString(string.Concat("https://cheaters.pro/ac-status/last_client_version.txt")));
            Start.Enabled = true;
         


            //WebClient web = new WebClient();
            //string CloudVersion = web.DownloadString("https://cheaters.pro/ac-status/last_client_version.txt");
            //string[] lines = File.ReadAllLines(@"config.dll");
            ////  Config.Logger("[PB] CUffffffffff");

            //foreach (string line in lines)
            ////   Config.Logger("[PB] sdsadssdaasdCU");

            //{
            //    if (line.Contains("game_version"))
            //        Config.Logger("[PB] hgfhfgCU");

            //    {
            //        var CurrentVersion = (line);
            //        MessageBox.Show(CurrentVersion);
            //    }
            //}


        }

        //private void DownloadFile(Uri uri, string path)
        //{
        //    WebClient webClientDld = new WebClient();
        //    webClientDld.DownloadProgressChanged += new DownloadProgressChangedEventHandler((object dsender, DownloadProgressChangedEventArgs de) =>
        //    {
        //        int bytesIn = Convert.ToInt32(de.BytesReceived);
        //        int totalBytes = Convert.ToInt32(de.TotalBytesToReceive);
        //        int percentage = Convert.ToInt32(Math.Floor((double)bytesIn / totalBytes * 100));
        //          total_label.Text = "Baixando... (" + percentage.ToString() + "% - " + de.BytesReceived + " de " + de.TotalBytesToReceive + ")";
        //        progressBar2.Value = percentage > 0 ? percentage : 0;
        //       // TotalBar.Width = (int)(received * 463 / maximum);
        //    });

        //    webClientDld.DownloadFileCompleted += new AsyncCompletedEventHandler((object dsender, AsyncCompletedEventArgs de) =>
        //    {
        //    lblstatus.Text = "Arquivo nº " + onDownloadingFileId + " baixado com sucesso. Inicie o jogo.";

        //        timerDownload.Start();
        //        Buttons_Visible(true, true, false);
        //        Buttons_Enable(true, true, false);
        //        Start.Enabled = true;
        //    });


        //    webClientDld.DownloadFileAsync(uri, path);
        //}

        private void DownloadFile(Uri uri, string path)
        {
            timer1.Stop();
            Jogar.Enabled = false;
            Veri.Enabled = false;
            Start.BackgroundImage = Resources.Start_Disable;
            Verif.BackgroundImage = Resources.Check_Disable;
            WebClient webClientDld = new WebClient();
            webClientDld.DownloadProgressChanged += new DownloadProgressChangedEventHandler((object dsender, DownloadProgressChangedEventArgs de) =>
            {
                timer1.Stop();
                Jogar.Enabled = false;
                Veri.Enabled = false;
                Start.BackgroundImage = Resources.Start_Disable;
                Verif.BackgroundImage = Resources.Check_Disable;
                int bytesIn = Convert.ToInt32(de.BytesReceived);
                int totalBytes = Convert.ToInt32(de.TotalBytesToReceive);
                int percentage = Convert.ToInt32(Math.Floor((double)bytesIn / totalBytes * 100));
                total_label.Text = "Baixando... (" + percentage.ToString() + "% - " + de.BytesReceived + " de " + de.TotalBytesToReceive + ")";
                timer1.Stop();
                Jogar.Enabled = false;
                Veri.Enabled = false;
                Start.BackgroundImage = Resources.Start_Disable;
                Verif.BackgroundImage = Resources.Check_Disable;
                progressBar2.Value = percentage > 0 ? percentage : 0;
                timer1.Stop();
                Jogar.Enabled = false;
                Veri.Enabled = false;
             //   Start.BackgroundImage = Resources.Start_Disable;
              //  Verif.BackgroundImage = Resources.Check_Disable;

            });

            webClientDld.DownloadFileCompleted += new AsyncCompletedEventHandler((object dsender, AsyncCompletedEventArgs de) =>
            {
                timer1.Stop();
                Jogar.Enabled = false;
                lblstatus.Text = "Atualização nº" + onDownloadingFileId + " baixada.";
                timer1.Stop();
                Jogar.Enabled = false;
                Veri.Enabled = false;
                timer1.Start();
                timerDownload.Start();
               
            });


            webClientDld.DownloadFileAsync(uri, path);
        }

        private void Launcher_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int left = Left;
                Point mousePosition = MousePosition;
                Ponto.X = left - mousePosition.X;
                int top = Top;
                Point point = MousePosition;
                Ponto.Y = top - point.Y;
            }
        }
        private void Launcher_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int x = Ponto.X;
                Point mousePosition = MousePosition;
                Left = x + mousePosition.X;
                int y = Ponto.Y;
                mousePosition = MousePosition;
                Top = y + mousePosition.Y;
            }
        }          
        private void Start_Click(object sender, EventArgs e)
        {

            if (File.Exists(string.Concat(Environment.CurrentDirectory, "/PBNightClub.exe")))
            {
                string token = "7896545647435646132";
                string XENON = "GameSec by XENON Protect";
                Process.Start(Application.StartupPath + @"\PBNightClub.exe", token);
                Process.Start(Application.StartupPath + @"\PB Shield.exe", XENON);
                Process.Start(Application.StartupPath + @"\LoaderGameSec.exe", XENON);
                Close();
            }
            else
            {
                MessageBox.Show("Executável não encontrado.", "PBLauncher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Button_Update_Click(object sender, EventArgs e)
        {
            StartUpdate();
        }
        private void StartUpdate()
        {
            //int num = + 1;
            //Buttons_Visible(false, false, true);
            //Buttons_Enable(false, false, true);
            //fileName.Visible = true;
            //  Directory.CreateDirectory(Environment.CurrentDirectory + "\\Patch");
            //try
            //{
            //    GameUpdate.DownloadFileAsync(new Uri("https://cheaters.pro/ac-status/Patch/Patch_" +  num + ".zip"), string.Concat(new object[]{Application.StartupPath, @"\Patch\Patch_",num, ".zip"}));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //Buttons_Visible(false, true, true);
            //Buttons_Enable(false, true, true);

            lblstatus.Text = "Baixando nova atualização...";


            int filesOK = 0;
            WebClient webClient = new WebClient();
            string Request = webClient.DownloadString("https://projectnightclub.buzz/launcher/files.json");

            jsonFiles = JObject.Parse(Request);

            for (int i = 1; i <= jsonFiles["files"].Count(); i++)
            {
                string curFileOutDir = textBoxSavePath.Text + @"\" + jsonFiles["files"]["file" + i]["name"];
                int curFileSize = Convert.ToInt32(jsonFiles["files"]["file" + i]["size"]);
                string curFileName = jsonFiles["files"]["file" + i]["name"].ToString();

                if (File.Exists(curFileOutDir) && curFileSize == new FileInfo(curFileOutDir).Length)
                    filesOK++;
            }

            if (filesOK >= jsonFiles["files"].Count())

                lblstatus.Text = "Você pode iniciar o jogo.";


            else
                timerDownload.Start();

            Verif.BackgroundImage = Resources.Check_Normal;
            Buttons_Visible(true, true, false);
            Buttons_Enable(true, true, false);
        }

    
        private void Verif_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.CurrentDirectory + @"\UserFileList.dat"))
            {
                MessageBox.Show("Erro ao localizar o arquivo UserFileList.dat", "UserFileList.dat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Config.Logger("[PB] Erro ao localizar o arquivo UserFileList.dat <<<");
                Environment.Exit(0);
            }
            else
            {
                CheckOPC();
            }
        }
        private void Fechar_Click(object sender, EventArgs e)
        {

            Sair.Visible = true;
            Jogar.Enabled = false;
            Veri.Enabled = false;
          //  Minimize.Enabled = false;
            //DialogResult Result = MessageBox.Show("Você deseja sair?", "PBLauncher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (Result == DialogResult.Yes)
            //{
            //    Environment.Exit(0);
            //    Config.Logger("[PB] PBLauncher fechado <<<");
            //  }
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region :: Mouse Events
        private void Fechar_MouseLeave(object sender, EventArgs e)
        {
            Fechar.Image = Resources.Closed_Normal1;
            Fechar.BackColor = Color.Transparent;
        }
        private void Fechar_MouseMove(object sender, MouseEventArgs e)
        {
            Fechar.Image = Resources.Closed_Over1;
            Fechar.BackColor = Color.Transparent;
        }
        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.Image = Resources.Hide_Normal;
            Minimize.BackColor = Color.Transparent;
        }
        private void Minimize_MouseMove(object sender, MouseEventArgs e)
        {
            Minimize.Image = Resources.Hide_Over;
            Minimize.BackColor = Color.Transparent;
        }
        private void Verif_MouseLeave(object sender, EventArgs e)
        {
            if (!loadingVerif)
            {
                Verif.BackgroundImage = Resources.Check_Normal;
                Verif.BackColor = Color.Transparent;
            }
        }
        private void Verif_MouseMove(object sender, MouseEventArgs e)
        {
            Verif.BackgroundImage = Resources.Check_Over;
            Verif.BackColor = Color.Transparent;
        }
        private void Button_Update_MouseLeave(object sender, EventArgs e)
        {
            Button_Update.BackgroundImage = Resources.Update_Normal;
            Button_Update.BackColor = Color.Transparent;
        }
        private void Button_Update_MouseMove(object sender, MouseEventArgs e)
        {
            Button_Update.BackgroundImage = Resources.Update_Over;
            Button_Update.BackColor = Color.Transparent;
        }
        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.BackgroundImage = Resources.Start_Normal;
            Start.BackColor = Color.Transparent;
        }
        private void Start_MouseMove(object sender, MouseEventArgs e)
        {
            Start.BackgroundImage = Resources.Start_Over;
            Start.BackColor = Color.Transparent;
        }
        #endregion
        public void CheckOPC()
        {
            loadingVerif = true;
          //  int bytesIn = Convert.ToInt32(de.BytesReceived);
          //  int totalBytes = Convert.ToInt32(de.TotalBytesToReceive);
           // int percentage = Convert.ToInt32(Math.Floor((double)bytesIn / totalBytes * 100));
            SortedList<string, string> strs = XMLoad(string.Concat(Environment.CurrentDirectory + "\\UserFileList.dat"));
            List<string> strs1 = new List<string>();
            lblstatus.Text = Config.CHECK_FILES;
            fileName.Visible = true;
            //   Buttons_Visible(true, true, false);
            //  Buttons_Enable(false, false, false);
            //  Verif.BackgroundImage = Resources.Check_Disable;
            //  Start.BackgroundImage = Resources.Start_Disable;
            Veri.Enabled = false;
            Jogar.Enabled = false;
            Config.Logger("[PB] Verificando integridade dos arquivos da cliente: ... //UserFileList.dat");
            for (int i = 0; i < strs.Count; i++)
            {
                Application.DoEvents();
                string item = strs.Keys[i];
                string startupPath = Environment.CurrentDirectory;
                int num = item.LastIndexOf("\\...");
                string str1 = item.Substring(num + 1);
                Config.Logger("[PB] Arquivo: " + item + " Modificado: " + 1);
                fileName.Text = str1;
                if (strs.TryGetValue(item, out string str))
                {
                    if (!File.Exists(string.Concat(startupPath, item)))
                    {
                        strs1.Add(item);
                    }
                    else if (GetMD5HashFromFile(string.Concat(startupPath, item)) != str)
                    {
                        strs1.Add(item);
                    }
                }
                Bar2SetProgress((ulong)i, (ulong)strs.Count);
                Update();
            }
            fileName.Visible = false;
            Veri.Enabled = true;
            Jogar.Enabled = true;
         //   Verif.BackgroundImage = Resources.Check_Normal;
            //   Start.BackgroundImage = Resources.Start_Normal;
          //  Jogar.Enabled = true;
            lblstatus.Text = Config.LAUNCHER_READY;
            loadingVerif = false;
            Config.Logger("[PB] Verificação concluida.");
            return;
        }

        public string GetMD5HashFromFile(string fileName)
        {
            string str = "";
            MD5 mD5 = MD5.Create();
            try
            {
                FileStream fileStream = File.OpenRead(fileName);
                str = BitConverter.ToString(mD5.ComputeHash(fileStream)).Replace("-", string.Empty);
                fileStream.Close();
            }
            catch
            {

            }
            return str;
        }

        public void Unzip(string TargetDir, string ZipToUnpack)
        {
            try
            {
                File.ReadAllText(string.Concat(Environment.CurrentDirectory + "\\Config.zpt"));
                using ZipFile zipFile = ZipFile.Read(ZipToUnpack);
                zipFile.ExtractProgress += Unzip_ExtractProgressChanged;
                int num = 0;
                int num2 = 0;
                using (IEnumerator<ZipEntry> enumerator = zipFile.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        if (!enumerator.Current.IsDirectory)
                        {
                            num2++;
                        }
                    }
                }
                fileName.Visible = true;
                foreach (ZipEntry zipEntry in zipFile)
                {
                    string FileName = zipEntry.FileName;
                    if (FileName.Contains("\\"))
                    {
                        int File = FileName.LastIndexOf("\\");
                        FileName = FileName.Substring(File + 1);
                    }
                    if (!zipEntry.IsDirectory)
                    {
                        fileName.Text = FileName;
                        int num4 = num + 1;
                        num = num4;
                        Bar2SetProgress((ulong)num4, (ulong)num2);
                    }
                    zipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(ToString());
            }
        }
        private void Unzip_ExtractProgressChanged(object sender, ExtractProgressEventArgs e)
        {
            try
            {
                if (e.TotalBytesToTransfer != 0L)
                {
                    Bar1SetProgress(e.BytesTransferred, e.TotalBytesToTransfer, false);
                }
                ArchiveBar.Refresh();
                ArchiveBar.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = true)]
        public static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        public static SortedList<string, string> XMLoad(string path)
        {
            SortedList<string, string> strs = new SortedList<string, string>();
            XmlDocument xmlDocument = new XmlDocument();
            FileStream fileStream = new FileStream(path, FileMode.Open);
            if (fileStream.Length != 0)
            {
                try
                {
                    xmlDocument.Load(fileStream);
                    for (XmlNode i = xmlDocument.FirstChild; i != null; i = i.NextSibling)
                    {
                        if ("list".Equals(i.Name))
                        {
                            for (XmlNode j = i.FirstChild; j != null; j = j.NextSibling)
                            {
                                if ("f".Equals(j.Name))
                                {
                                    XmlNamedNodeMap attributes = j.Attributes;
                                    string value = attributes.GetNamedItem("n").Value;
                                    if (!strs.ContainsKey(value))
                                    {
                                        strs.Add(value, attributes.GetNamedItem("n").Value);
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {

                }
            }
            return strs;
        }

        private void timerDownload_Tick_1(object sender, EventArgs e)
        {

           

            Jogar.Enabled = false;
            Veri.Enabled = false;
           // Start.BackgroundImage = Resources.Start_Disable;
           // Verif.BackgroundImage = Resources.Check_Disable;

            timerDownload.Stop();
         //   MessageBox.Show("Atualização disponivel");
            Jogar.Enabled = false;
            Veri.Enabled = false;
          //  Start.BackgroundImage = Resources.Start_Disable;
         //   Verif.BackgroundImage = Resources.Check_Disable;


            if (onDownloadingFileId < jsonFiles["files"].Count())

            {
                onDownloadingFileId++;
                DownloadFile(new Uri(jsonFiles["files"]["file" + onDownloadingFileId]["url"].ToString()), textBoxSavePath.Text + @"\" + jsonFiles["files"]["file" + onDownloadingFileId]["name"]);
               Jogar.Enabled = false;
                Start.BackgroundImage = Resources.Start_Disable;
            }
            else
                onDownloadingFileId = 0;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            total_label.Visible = false;
            lblstatus.Text = "Você pode iniciar o jogo.";
            Jogar.Enabled = true;
            Veri.Enabled = true;
            //Buttons_Visible(true, true, false);
            //Buttons_Enable(true, true, false);
          //  Start.BackgroundImage = Resources.Start_Normal;
         //   Verif.BackgroundImage = Resources.Check_Normal;
            timer1.Stop();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {



            if (File.Exists(string.Concat(Environment.CurrentDirectory, "/PointBlank.exe")))
            {
                string token = Ptoken.Text;
                string GameID = " /GameID:GarenaPB /Token: " + token;
                string XENON = "GameSec by XENON Protect";
                Process.Start(Application.StartupPath + @"\PointBlank.exe", GameID);
             //   Process.Start(Application.StartupPath + @"\PB Shield.exe", XENON);
              //  Process.Start(Application.StartupPath + @"\LoaderGameSec.exe", XENON);
                Config.Logger("[PB] Jogo inicializado.");
                Close();
            }
            else
            {
                Config.Logger("[ERRO] Executável não encontrado.");
                MessageBox.Show("Executável não encontrado.", "PBLauncher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.CurrentDirectory + @"\UserFileList.dat"))
            {
                MessageBox.Show("Erro ao localizar o arquivo UserFileList.dat", "UserFileList.dat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Config.Logger("[PB] Erro ao localizar o arquivo UserFileList.dat <<<");
                Environment.Exit(0);
            }
            else
            {

                CheckOPC();
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Config.Logger("[PB] PBLauncher finalizado <<<");
            Environment.Exit(0);
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Sair.Visible = false;
            Jogar.Enabled = true;
            Veri.Enabled = true;
            Minimize.Enabled = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            AttDetect.Visible = false;
            timerDownload.Start();
            total_label.Visible = true;
        }

        private void Sair_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AttDetect_Paint(object sender, PaintEventArgs e)
        {
            Jogar.Enabled = false;
              Veri.Enabled = false;
            lblstatus.Text = "Nova atualização disponível";
        }

        //private void DownloadFile(Uri uri, string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
