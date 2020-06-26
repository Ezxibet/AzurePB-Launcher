using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using liblauncher;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

namespace Launcher
{
    public partial class Connect : Form
    {
        public WebClient WebClient = new WebClient();
        public Connect()
        {
            InitializeComponent();
        }
        private void Please_Wait_Load(object sender, EventArgs e)
        {
            PBLauncherV();
            Referencias();
        }

        private void PBLauncherV()
        {

            WebClient web = new WebClient();
            string Dados = web.DownloadString("http://54.39.81.71/pblauncher/LauncherVersion/versao1.txt");

            if (Dados == "0")
            {
                MessageBox.Show("Estamos realizando uma manutenção no servidor." + "\n" + "O launcher ficará offline por tempo indeterminado.", "Manutenção", MessageBoxButtons.OK, MessageBoxIcon.Error);            
                System.Environment.Exit(0);
            }
            else if (Dados == "1")
            {
                MessageBox.Show("Essa versão do PBLauncher está desatualizada, visite nosso site para baixar a nova versão.", "Nova versão do launcher disponível", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Process.Start("https://azurepb.net/");             
                System.Environment.Exit(0);
            }

            else if (Dados == "2")
            {
               
            }


        }

     

        private void Verificar()
        {
            try
            {
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(Send.host), Send.port);
                client.Connect(endpoint);
                client.Close();
                 Start.RunWorkerAsync();
             
            }
            catch
            {
               MessageBox.Show("Não foi obtida nenhuma resposta do servidor.", "PBLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return;

        }
        private void Referencias()
        {
            if (!File.Exists(Environment.CurrentDirectory + @"\i3BaseUp.dll"))
            {
                MessageBox.Show("Erro ao localizar o arquivo i3BaseUp.dll", "i3BaseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            if (!File.Exists(Environment.CurrentDirectory + @"\Newtonsoft.Json.dll"))
            {
                MessageBox.Show("Erro ao localizar o arquivo Newtonsoft.Json.dll", "Newtonsoft.Json", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            if (!File.Exists(Environment.CurrentDirectory + @"\Newtonsoft.Json.xml"))
            {
                MessageBox.Show("Erro ao localizar o arquivo Newtonsoft.Json.xml", "Newtonsoft.Json", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            //if (!File.Exists(Environment.CurrentDirectory + @"\PB Shield.exe"))
            //{
            //    MessageBox.Show("Erro ao localizar o anti cheat PB Shield.exe", "PB Shield", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Environment.Exit(0);
            //}

            //if (!File.Exists(Environment.CurrentDirectory + @"\LoaderGameSec.exe"))
            //{
            //    MessageBox.Show("Erro ao localizar o LoaderGameSec.exe", "LoaderGameSec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Environment.Exit(0);
            //}
        }
        private void Start_DoWork(object sender, DoWorkEventArgs e)
        {
            label_launcher.Location = new Point(12, 11);
            label_launcher.Text = "Conectando-se ao servidor...";
            Thread.Sleep(900);
            Referencias();
            Thread.Sleep(900);
            InitializeComponent();
        }
        private void Start_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void label_launcher_Click(object sender, EventArgs e)
        {

        }

        private void Jogar_Click(object sender, EventArgs e)
        {
           
            Verificar();

        }
    }
}
