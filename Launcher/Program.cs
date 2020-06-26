using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using i3BaseUp;

namespace Launcher
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            WebClient Web = new WebClient();
            Process aProcess = Process.GetCurrentProcess();
            string aProcName = aProcess.ProcessName;
            if (Process.GetProcessesByName(aProcName).Length > 1)
            {
                MessageBox.Show("Não é permitido abrir dois programas ao mesmo tempo.", "PBLauncher", MessageBoxButtons.OK);
                return;
            }
            using var Form = new Connect();
            try
            {
                if (Form.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new PBLauncher());
                }
            }
            catch
            {
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);;
        }
    }
}
