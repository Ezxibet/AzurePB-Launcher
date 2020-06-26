
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

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
            Process aProcess = Process.GetCurrentProcess();
            string aProcName = aProcess.ProcessName;
            if (Process.GetProcessesByName(aProcName).Length > 1)
            {
                MessageBox.Show("Não é permitido abrir dois programas ao mesmo tempo.", "PBLauncher", MessageBoxButtons.OK);
                return;
            }
            Application.Run(new PBLauncher());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}
