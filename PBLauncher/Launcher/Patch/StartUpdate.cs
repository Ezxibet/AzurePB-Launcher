using Launcher.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public class Atualizar
    {
        public class AutoUpdateEventArg
        {
            public bool UpdateSuccess {get; set;}
            public bool NeedToUpdate {get; set;}
            public AutoUpdateEventArg(bool UpdateSuccess, bool NeedToUpdate)
            {
                this.UpdateSuccess = UpdateSuccess;
                this.NeedToUpdate = NeedToUpdate;
            }
        }
        public delegate void AutoUpdateCheckDelegate(AutoUpdateEventArg arg);
        public event AutoUpdateCheckDelegate CheckForUpdatesCompleted;
        private void OnCheckForUpdatesCompleted(AutoUpdateEventArg arg)
        {
            CheckForUpdatesCompleted?.Invoke(arg);
        }
        public string value;
        private readonly Settings settings;
        private readonly PBLauncher Launcher;
        public WebClient Downloader {get;}
        public int CurrentVersion {get; set;}
        public int ServerVersion {get; set;}

        public Atualizar()
        {
            Downloader = new WebClient();
            settings = new Settings();
            settings.Load();
            ServerVersion = 0;
            CurrentVersion = settings.VERSION_UPDATE;
        }
        public bool CheckSettings()
        {
            if (value == null) return true;
            for (int i = 0; i < value.Length; i++) if (!char.IsWhiteSpace(value[i])) return false;
            return true;
        }
        public void CheckForUpdates()
        {
            Thread checkerThread = new Thread(new ThreadStart(delegate
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(settings.LAST_CLIENT_VERSION);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    using StreamReader reader = new StreamReader(response.GetResponseStream());
                    ServerVersion = int.Parse(reader.ReadToEnd());
                    if (ServerVersion > CurrentVersion) OnCheckForUpdatesCompleted(new AutoUpdateEventArg(true, true));
                    else OnCheckForUpdatesCompleted(new AutoUpdateEventArg(true, false));
                }
                catch
                {
                    OnCheckForUpdatesCompleted(new AutoUpdateEventArg(false, false));
                }}));
            checkerThread.Start();
        }
        public void DownloadUpdates()
        {
            Launcher.Buttons_Visible(false, true, true);
            Launcher.Buttons_Enable(false, false, true);
            Launcher.CreateDirectory();
            Downloader.DownloadFileAsync(new Uri(settings.UPDATE_SERVER_LOCAL), settings.UPDATE_SERVER_LOCAL);
            Downloader.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(Downloader_DownloadFileCompleted);
        }
        private void Downloader_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Launcher.Buttons_Visible(true, true, false);
            Launcher.Buttons_Enable(true, true, false);
            settings.VERSION_UPDATE = ServerVersion;
            settings.Save();
            Launcher.DeleteDirectory();
        }
    }
}
