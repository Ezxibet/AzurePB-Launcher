using Ionic.Zip;
using Launcher.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Launcher
{
    public partial class PBLauncher : Form
    {
        public WebClient WebClient = new WebClient();
        public Conexao Conexao;
        private Point Ponto;
        private readonly Atualizar Update;
        private readonly CookieContainer Cookie = null;
        string Token = "";

        public PBLauncher()
        {
            InitializeComponent();
        }
        public void FileBar(long received, long maximum)
        {
            ArchiveBar.Width = (int)(received * 623 / maximum);
        }
        public void ProgressBar(int received, int maximum)
        {
            TotalBar.Width = received * 623 / maximum;
        }
        public void CreateDirectory()
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/Patch");
        }
        public void DeleteDirectory()
        {
            if (Directory.Exists(string.Concat(Environment.CurrentDirectory, "/Patch")))
            {
                Directory.Delete(string.Concat(Environment.CurrentDirectory, "/Patch"), true);
            }
        }
        private void Launcher_Load(object sender, EventArgs e)
        {
            Util.LoadText();
            LoginPainel.Visible = true;
            lblogin.Text = "Aguardando usuario...";
            Status.Text = Util.Status;
            Arquivo.Text = Util.File;
            Total.Text = Util.Total;
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
        private void Fechar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Você tem certeza que deseja sair?", "PBLauncher", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Start.BackgroundImage = Resources.Iniciar_Disabled;
            Start.BackColor = Color.Black; 

            if (File.Exists(string.Concat(Environment.CurrentDirectory, "/PointBlank.exe")))
            {
                Process.Start(Environment.CurrentDirectory + "/PointBlank.exe" + " /GameID:GarenaPB /Token: " + Token);
            }
            else
            {
                MessageBox.Show("Executável não encontrado.", "PBLauncher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Button_Update_Click(object sender, EventArgs e)
        {
            Update.DownloadUpdates();
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

        #region :: Mouse Event 
        private void Start_MouseEnter(object sender, EventArgs e)
        {
            Start.BackgroundImage = Resources.Iniciar_Over1;
            Start.BackColor = Color.Black;
        }
        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.BackgroundImage = Resources.Iniciar_Normal1;
            Start.BackColor = Color.Black;
        }
        private void Button_Update_MouseEnter(object sender, EventArgs e)
        {
            Button_Update.BackgroundImage = Resources.Atualizar_Over1;
            Button_Update.BackColor = Color.Black;
        }
        private void Button_Update_MouseLeave(object sender, EventArgs e)
        {
            Button_Update.BackgroundImage = Resources.Atualizar_Normal1;
            Button_Update.BackColor = Color.Black;
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Verif_MouseEnter(object sender, EventArgs e)
        {
            Verif.ForeColor = Color.Red;
        }
        private void Verif_MouseLeave(object sender, EventArgs e)
        {
            Verif.ForeColor = Color.White;
        }

        #endregion :: Mouse Event Handler Mouse Events

        protected string GetMD5HashFromFile(string fileName)
        {
            string str;
            using (MD5 mD5 = MD5.Create())
            {
                using FileStream fileStream = File.OpenRead(fileName);
                str = BitConverter.ToString(mD5.ComputeHash(fileStream)).Replace("-", string.Empty);
            }
            return str;
        }
        private string PerformRequest(string url, string username, string password)
        {
            HttpWebRequest cookie = (HttpWebRequest)WebRequest.Create(url);
            cookie.CookieContainer = Cookie;
            string str = string.Concat(new string[] { "username=", username, "&password=", password, "&Hash=", GetMD5HashFromFile(string.Concat(Process.GetCurrentProcess().ProcessName, ".exe"))});
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            cookie.Method = "POST";
            cookie.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
            cookie.ContentLength = bytes.Length;
            using (Stream requestStream = cookie.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
            }
            WebResponse response = (HttpWebResponse)cookie.GetResponse();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
        private void Login_Button_MouseEnter(object sender, EventArgs e)
        {
            Login_Button.BackgroundImage = Resources.Login_Over;
            Login_Button.BackColor = Color.Black;
        }
        private void Login_Button_MouseLeave(object sender, EventArgs e)
        {
            Login_Button.BackgroundImage = Resources.Login_Normal;
            Login_Button.BackColor = Color.Black;
        }
        private void Login_Button_MouseMove(object sender, MouseEventArgs e)
        {
            Login_Button.BackgroundImage = Resources.Login_Over;
            Login_Button.BackColor = Color.Black;
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            string str = PerformRequest(string.Concat(Config.URL, "/check.php"), LoginBox.Text, PasswordBox.Text);
            if (str == "Fail")
            {
                lblogin.ForeColor = Color.Red;
                lblogin.Text = "Usuário ou senha inválidos.";
                MessageBox.Show("Usuário ou senha inválidos.", "PBLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordBox.Text = "";
                LoginBox.Text = "";
                LoginBox.Focus();
                return;
            }
            else if (str == "Ban")
            {
                Warning myNewForm = new Warning();
                myNewForm.Show();
                PasswordBox.Text = "";
                LoginBox.Text = "";
                LoginBox.Focus();
            }
            else if (str != "BanHWID")
            {
                Token = str;
            }
            else
            {
               PasswordBox.Text = "";
               LoginBox.Text = "";
               LoginBox.Focus();
               LoginPainel.Visible = false;
            }
            return;
        }
    }
}

