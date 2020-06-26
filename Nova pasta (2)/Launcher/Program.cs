using PointBlank.DLL;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PointBlank.Launcher
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			using (PointBlank.Launcher.Connection connection = new PointBlank.Launcher.Connection())
			{
				try
				{
					File.Delete("UPDATE.exe");
					if (connection.ShowDialog() == DialogResult.OK)
					{
						WebClient webClient = new WebClient();
						if (File.Exists(string.Concat(Application.StartupPath, "\\", Modul.Ver)))
						{
							Application.Run(new PointBlank.Launcher.Launcher(connection, new AuthModul()));
						}
						else
						{
							MessageBox.Show("O arquivo não pode ser encontrado..", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Hand);
							if (MessageBox.Show("Fazendo o download do arquivo ausente....", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
							{
								webClient.DownloadFile(string.Concat(Modul.WEB, "client/", Modul.Ver), Modul.Ver);
								Application.Restart();
							}
						}
					}
				}
				catch
				{
					connection.Close();
				}
			}
		}
	}
}