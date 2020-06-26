using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Conexao : Form
    {
        public WebClient WebClient = new WebClient();
        public string IP_LAUNCHER = "127.0.0.1";
        public int PORT_LAUNCHER = 2345;
        public Conexao()
        {
            InitializeComponent();
        }
        public void Connection()
        {
            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(IP_LAUNCHER, PORT_LAUNCHER);
                Start.RunWorkerAsync();
            }
            catch(Exception)
            {
                MessageBox.Show("Não foi possível conectar ao servidor.", "PBLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        public void Arquivos()
        {
            if (!File.Exists(string.Concat(Environment.CurrentDirectory + "/Ionic.Zip.dll")))
            {
                WebClient.DownloadData(Config.URL + "/File/Ionic.Zip.dll" + string.Concat(Environment.CurrentDirectory + "/Ionic.Zip.dll"));
            }
            if (!File.Exists(string.Concat(Environment.CurrentDirectory + "/UserFileList.dat")))
            {
                WebClient.DownloadData(Config.URL + "/File/UserFileList.dat" + string.Concat(Environment.CurrentDirectory + "/UserFileList.dat"));
            }
        }
        private string GetHash(string GetHash, HashAlgorithm hashAlgorithm)
        {
            FileStream fileStream = File.OpenRead(GetHash);
            string empty;
            {
                empty = BitConverter.ToString(hashAlgorithm.ComputeHash(fileStream)).ToLower().Replace("-", "");
            }
            return empty;
        }
        public void UpdateLauncher()
        {
            if (!WebClient.DownloadString(string.Concat(Config.URL + "/launcher_version.txt")).Equals(GetHash(string.Concat(Application.StartupPath, "\\PBLauncher.exe"), new MD5CryptoServiceProvider())))
            {
                try
                {
                    Process.Start(string.Concat(Environment.CurrentDirectory + "/Update.exe"));
                    Environment.Exit(0);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao atualizar o PBLauncher.", "PBLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        }
        private void Please_Wait_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Connection();
        }
        private void Start_DoWork(object sender, DoWorkEventArgs e)
        {
            label_launcher.Location = new Point(254, 217);
            label_launcher.Text = "Verificando a conexão com o servidor remoto.";
            Thread.Sleep(1500);
            UpdateLauncher();
            Thread.Sleep(1500);
            Arquivos();
        }
        private void Start_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void LoadingOpacityUpdater_Tick(object sender, EventArgs e)
        {

            if (Opacity >= 1)
            {
                LoadingOpacityUpdater.Stop();
                Opacity = 1;
            }
            else
            {
                Opacity += 0.09;
            }
        }
        private void Conexao_Shown(object sender, EventArgs e)
        {
            LoadingOpacityUpdater.Start();
        }
    }
}
