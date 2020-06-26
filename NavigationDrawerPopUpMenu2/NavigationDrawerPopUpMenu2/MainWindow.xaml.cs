using Ionic.Zip;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing;

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public bool Log = false;
        protected string VersionL = "1.4";
        int sizeall;
        int sizeatt = 1;
        string tok;
        string archive;
        string dslink;

        WebClient webclient;

        BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();
            UserControlCreate usc = new UserControlCreate();
            GridMain.Children.Clear();
            GridMain.Children.Add(usc);
            //
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            this.backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            this.backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            //
            CheckV();
            //
            if (File.Exists("save.txt"))
            {
                txtuserl.Text = File.ReadAllText("save.txt");
                CheckUser.IsChecked = true;
            }
        }

        #region update
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Pg1.IsIndeterminate = false;
            archivetxt.Text =  "Client atualizada, pode iniciar o jogo!";
            Pg1.Value = 100;
            pgtxt.Text = "100";
            Start.IsEnabled = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            sizeatt = e.ProgressPercentage + sizeatt;
            updprocess(sizeatt);
        }

        private void updprocess(int value)
        {
            if (Pg1.IsIndeterminate)
                Pg1.IsIndeterminate = false;
            if (value < 0)
                return;
            if (value > 100)
                value = 100;
            //pgtxt.Text = (int.Parse(pgtxt.Text) + value).ToString();
            archivetxt.Text = "Baixando: " + archive;
            pgtxt.Text = value.ToString();
            Pg1.Value = value; 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string Server = "https://badnesspb.ml/pblauncher/launcher/update/";

            //Defines application root
            string Root = AppDomain.CurrentDomain.BaseDirectory;

            //Make sure version file exists
            FileStream fs = null;
            if (!File.Exists("version"))
            {
                using (fs = File.Create("version"))
                {
                    
                }

                using (StreamWriter sw = new StreamWriter("version"))
                {
                    sw.Write("1.0");
                }
            }
            //checks client version
            string lclVersion;
            using (StreamReader reader = new StreamReader("version"))
            {
                lclVersion = reader.ReadLine();
            }
            decimal localVersion = decimal.Parse(lclVersion);


            //list of updates
            XDocument serverXml = XDocument.Load(Server + "Updates.xml");

            //All size Archives || 
            foreach (XElement update in serverXml.Descendants("update"))
            {
                string version = update.Element("version").Value;
                string file = update.Element("file").Value;
                int size = int.Parse(update.Element("size").Value);
                if (decimal.Parse(version) <= localVersion)
                    size = 0;
                sizeall = sizeall + size;
            }

            //Update Process
            foreach (XElement update in serverXml.Descendants("update"))
            {
                string version = update.Element("version").Value;
                string file = update.Element("file").Value;
                archive = update.Element("name").Value;
                

                decimal serverVersion = decimal.Parse(version);

                string sUrlToReadFileFrom = Server + file;

                string sFilePathToWriteFileTo = Root + file;

                if (serverVersion > localVersion)
                {

                    Uri url = new Uri(sUrlToReadFileFrom);
                    System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                    System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                    response.Close();

                    Int64 iSize = response.ContentLength;

                    Int64 iRunningByteTotal = 0;

                    

                    using (System.Net.WebClient client = new System.Net.WebClient())
                    {
                        using (System.IO.Stream streamRemote = client.OpenRead(new Uri(sUrlToReadFileFrom)))
                        {
                            using (Stream streamLocal = new FileStream(sFilePathToWriteFileTo, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                int iByteSize = 0;
                                byte[] byteBuffer = new byte[iSize];
                                while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                                {
                                    streamLocal.Write(byteBuffer, 0, iByteSize);
                                    iRunningByteTotal += iByteSize;
                                    

                                    double dIndex = (double)(iRunningByteTotal);
                                    double dTotal = (double)byteBuffer.Length;
                                    double dProgressPercentage = (dIndex / sizeall);
                                    int iProgressPercentage = (int)(dProgressPercentage * 100);
                                    
                                    backgroundWorker1.ReportProgress(iProgressPercentage);
                                   }

                                streamLocal.Close();
                            }

                            streamRemote.Close();
                        }
                    }
                   

                    //unzip
                    using (ZipFile zip = ZipFile.Read(file))
                    {
                        foreach (ZipEntry zipFiles in zip)
                        {
                            zipFiles.Extract(Root + "\\", true);
                        }
                    }

                    //download new version
                    File.WriteAllText("version", version);

                    //Delete Zip File
                    File.Delete(file);
                }
            }

        }
        #endregion

        public static string PhAdr()
        {
            string str;
            string str1 = "SOFTWARE\\Microsoft\\Cryptography";
            string str2 = "MachineGuid";
            using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey registryKey1 = registryKey.OpenSubKey(str1))
                {
                    if (registryKey1 == null)
                    {
                        //throw new KeyNotFoundException(string.Format("Key Not Found: {0}", str1));
                    }
                    object value = registryKey1.GetValue(str2);
                    if (value == null)
                    {
                        throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", str2));
                    }
                    str = value.ToString();
                }
            }
            return str;
        }

        private string GetData(string url, string dados)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.CookieContainer = Cookie; // use the global cookie variable
            string postData = dados;
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

            response.Close();
        }

        private async void Mmsg(string text, int time, int close)
        {
            MsgB_Close.IsEnabled = false;
            //MsgB_Close.Visibility = Visibility.Hidden;
            MsgBtxt.Text = text;
            MsgB.Visibility = Visibility.Visible;

            if(time == 0)
            {
                MsgB_Close.IsEnabled = true;
                MsgB_Close.Visibility = Visibility.Visible;
                if(close == 1)
                {
                    MsgB_Close.Click += new RoutedEventHandler((object s1, RoutedEventArgs s2)=> { Close(); });
                }
            }
            else
            {
                MsgB_Close.Visibility = Visibility.Hidden;
                await Task.Delay(time);

                MsgB.Visibility = Visibility.Hidden;
            }

        }

        private async void CheckV()
        {
            MsgB_Close.IsEnabled = false;
            MsgBtxt.Text = "Aguarde...";
            MsgB.Visibility = Visibility.Visible;


            await Task.Delay(2000);
            try
            {
                WebClient webb = new WebClient();
                if (VersionL == webb.DownloadString("https://badnesspb.ml/pblauncher/launcher/update_launcher/version.txt").ToString())
                {
                    Player resultPlayer = JsonConvert.DeserializeObject<Player>(GetData("https://badnesspb.ml/pblauncher/launcher/open.php", "Open=LauncherWEB"));
                    if (resultPlayer.message != "Success")
                    {
                        MsgBtxt.Text = resultPlayer.message;
                        MsgB_Close.IsEnabled = true;
                        MsgB_Close.Click += new RoutedEventHandler((object s1, RoutedEventArgs e1) => { Close(); });
                    }
                    else
                    {
                        UserControlCreate user = new UserControlCreate();
                        MsgB.Visibility = Visibility.Hidden;
                        tok = resultPlayer.token;
                        dslink = resultPlayer.linkds;
                    }
                }
                else
                {
                    MsgBtxt.Text = "Uma nova versão do launcher está disponivel.";
                    MsgB_Close.Content = "Baixar";
                    MsgB_Close.IsEnabled = true;
                    MsgB_Close.Click += new RoutedEventHandler((object s1, RoutedEventArgs e1) => { System.Diagnostics.Process.Start("update.exe"); Close(); });
                }
            }
            catch
            {
                MsgBtxt.Text = "Não foi possivel conectar ao servidor";
                MsgB_Close.IsEnabled = true;
                MsgB_Close.Click += new RoutedEventHandler((object s1, RoutedEventArgs e1) => { Close(); });
            }
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            MenuL.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new UserControlHome();
                    //GridMain.Children.Add(usc);
                    MenuA.Children.Add(usc);
                    MenuAcc.Visibility = Visibility.Visible;
                    ItemHome.IsEnabled = false;
                    break;
                case "Clos":
                    usc = new UserControlCreate();
                    GridMain.Children.Add(usc);
                    break;
                case "Inic":
                    usc = new UserControlHome();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }

        private void Ranking_Click(object sender, RoutedEventArgs e)
        {
            
            if(LineR.Margin == new Thickness(184, 50, -164, 9))
                Mmsg("Atualizando Rank...", 1000, 0);
            else
                Mmsg("Carregando Rank...", 1000, 0);


            Upd.Visibility = Visibility.Hidden;
            upd1.Visibility = Visibility.Hidden;
            Start.Visibility = Visibility.Hidden;
            LineR.Margin = new Thickness(184, 50, -164, 9);
            UserControlHome usr = new UserControlHome();
            GridMain.Children.Clear();
            GridMain.Children.Add(usr);

        }

        private void Inicio_Click(object sender, RoutedEventArgs e)
        {
            if (Log)
            {
                Upd.Visibility = Visibility.Visible;
                Start.Visibility = Visibility.Visible;
            }
            else
            {
                upd1.Visibility = Visibility.Visible;
                Start.Visibility = Visibility.Visible;
            }
            LineR.Margin = new Thickness(10, 52, 10, 7);
            UserControlCreate usc = new UserControlCreate();
            GridMain.Children.Clear();
            GridMain.Children.Add(usc);
        }

        private void Close_MenuAcc_Click(object sender, RoutedEventArgs e)
        {

            MenuAcc.Visibility = Visibility.Hidden;
        }

        private void ItemHome_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MenuL.Children.Clear();
           // MenuAcc.Children.Add(usc);
           // MenuAcc.Visibility = Visibility.Visible;
            if (Log)
            {
                MenuAcc.Visibility = Visibility.Visible;
                MenuL.Children.Add(MenuA);
            }
            else
            {
                MenuAcc.Visibility = Visibility.Visible;
                MenuL.Children.Add(Account);
                
                //Account.Visibility = Visibility.Visible;
            }

        }

        private async void Btnlogin_Click(object sender, RoutedEventArgs e)
       {
            btnlogin.IsEnabled = false;
            MsgB_Close.IsEnabled = false;
            MsgBtxt.Text = "Verificando Dados...";
            MsgB.Visibility = Visibility.Visible;
            MsgB_Close.Visibility = Visibility.Visible;

            await Task.Delay(2000);
            
                Player resultPlayer = JsonConvert.DeserializeObject<Player>(GetData("https://badnesspb.ml/pblauncher/launcher/login.php", "txtUsername=" + txtuserl.Text + "&txtPassword=" + txtpassl.Password + "&tk=" + tok + "&adr=" + PhAdr()));
                if (resultPlayer.message == "Verifique seus dados!")
                {
                    MsgBtxt.Text = resultPlayer.message;
                    MsgB_Close.IsEnabled = true;
                    btnRegister.IsEnabled = true;
                }
                else
                {
                    try
                    {


                        MsgBtxt.Text = "Logado com sucesso!";
                    //Accounta.Foreground = System.Windows.Media.Brushes.Green;
                        Accounta.Foreground = Pg1.Foreground;
                        Accounta.Kind = MaterialDesignThemes.Wpf.PackIconKind.Account;
                        Logarr.Text = "Minha ACC";
                        Logarr.Foreground = System.Windows.Media.Brushes.Green;
                        if (resultPlayer.email == "404")
                        {
                            Accounta.Foreground = System.Windows.Media.Brushes.Red;
                            Accounta.Kind = MaterialDesignThemes.Wpf.PackIconKind.AccountAlert;
                            btnDefEmail.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            btnDefEmail.Visibility = Visibility.Hidden;
                            lblemail.Text = resultPlayer.email;
                        }
                        Log = true;
                        llblname.Text = resultPlayer.name;
                        lblclan.Text = resultPlayer.clan;
                        lblkill.Text = resultPlayer.kill.ToString();
                        lbldeath.Text = resultPlayer.death.ToString();
                        lbldesist.Text = resultPlayer.desistencia.ToString();
                        lblcash.Text = resultPlayer.cash.ToString();
                        lblgold.Text = resultPlayer.gold.ToString();
                        System.Windows.Media.Imaging.BitmapImage img = new System.Windows.Media.Imaging.BitmapImage(new Uri(string.Concat("https://badnesspb.ml/pblauncher/launcher/web/patentes/" + resultPlayer.rank + ".png")));
                        Patente.Source = img;
                        tok = resultPlayer.token;
                        MenuL.Children.Remove(Account);
                        Account.Visibility = Visibility.Hidden;
                        MenuAcc.Visibility = Visibility.Visible;
                        MenuA.Visibility = Visibility.Visible;
                        MenuL.Children.Add(MenuA);
                        MenuAcc.Visibility = Visibility.Hidden;
                        upd1.Visibility = Visibility.Hidden;
                        await Task.Delay(1000);
                        MsgB.Visibility = Visibility.Hidden;
                        Upd.Visibility = Visibility.Visible;
                        Register.Visibility = Visibility.Hidden;
                        Inicio_Click(sender,e);
                        await Task.Delay(2000);
                        backgroundWorker1.RunWorkerAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            btnlogin.IsEnabled = true;
        }

        private void AppClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AppMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MsgB_Close_Click(object sender, RoutedEventArgs e)
        {
            MsgB.Visibility = Visibility.Hidden;
        }

        private void ItemCreate_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Txtpassr1_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Btnopregister_Click(object sender, RoutedEventArgs e)
        {
            Btnopregister.IsEnabled = false;
        }

        private void Close_Register_Click(object sender, RoutedEventArgs e)
        {
            Btnopregister.IsEnabled = true;
        }

        private async void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            btnRegister.IsEnabled = false;
            MsgB_Close.IsEnabled = false;
            MsgB_Close.Visibility = Visibility.Visible;
            MsgBtxt.Text = "Verificando Dados...";
            MsgB.Visibility = Visibility.Visible;


            await Task.Delay(2000);

            Player resultPlayer = JsonConvert.DeserializeObject<Player>(GetData("https://badnesspb.ml/pblauncher/launcher/register.php", "txtUsername=" + txtuserr.Text + "&txtPassword=" + txtpassr1.Password + "&txtConfPassword=" + txtpassr2.Password + "&email=" + txtemailr.Text + "&tk=" + tok + "&adr=" + PhAdr()));          
            if (resultPlayer.message != "Success")
            {
                MsgBtxt.Text = resultPlayer.message;
                MsgB_Close.IsEnabled = true;
                btnRegister.IsEnabled = true;
            }
            else {

                MsgBtxt.Text = "Registrado com sucesso";
                MsgB_Close.IsEnabled = true;
                btnRegister.IsEnabled = false;
            }
            
        }

        private async void Btn_SetEmail_Click(object sender, RoutedEventArgs e)
        {
            Btn_SetEmail.IsEnabled = false;
            txtbMsgStatus.Text = "Aguarde...";

            await Task.Delay(2000);

            Player resultPlayer = JsonConvert.DeserializeObject<Player>(GetData("https://badnesspb.ml/pblauncher/launcher/setemail.php", "tk=" + tok + "&email=" + txtbsetemail.Text));
            if (resultPlayer.message != "Success")
            {
                txtbMsgStatus.Text = resultPlayer.message;
                Btn_SetEmail.IsEnabled = true;
            }
            else
            {
                Accounta.Foreground = System.Windows.Media.Brushes.Green;
                Accounta.Kind = MaterialDesignThemes.Wpf.PackIconKind.AccountCheck;
                SetEmail.Visibility = Visibility.Hidden;
                Mmsg("Email Definido: " + txtbsetemail.Text, 0, 0);
                lblemail.Text = resultPlayer.email;
                btnDefEmail.Visibility = Visibility.Hidden;
                tok = resultPlayer.token;
            }
        }

        private void BtnDefEmail_Click(object sender, RoutedEventArgs e)
        {
            SetEmail.Visibility = Visibility.Visible;
        }

        private void CheckUser_Click(object sender, RoutedEventArgs e)
        {
            
            if (CheckUser.IsChecked == true)
            {
                File.WriteAllText("save.txt", txtuserl.Text);
            }
            else
            {
                File.Delete("save.txt");
            }
        }

        private void Txtuserl_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(CheckUser.IsChecked == true)
            {
                File.WriteAllText("save.txt", txtuserl.Text);
            }
        }

        private void ItemDs_MouseUp(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(dslink);
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (System.IO.File.Exists("Icon.exe"))
            {
                Process.Start("Icon.exe");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ant Cheat não encontrado.");
            }
            if (File.Exists("PointBlankBadness.exe"))
                System.Diagnostics.Process.Start("PointBlankBadness.exe", "45563324245198");
            else
                Mmsg("Não foi possivel encontrar o arquivo PointBlankBadness.exe. " + " O Launcher será fechado!", 0, 1);
            this.Close();
        }

        private void Login_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ItemHome_MouseUp(sender, e);
        }
    }
}
