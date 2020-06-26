using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using PointBlank.Launcher.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace PointBlank.Launcher
{
	public class Connection : Form
	{
		public Computer MyComputer = new Computer();

		private bool Flag = true;

		public WebClient Web = new WebClient();

		public Process[] Processos;

		private IContainer components;

		private System.Windows.Forms.Label Label;

		public BackgroundWorker Start;

		public Connection()
		{
			this.InitializeComponent();
			try
			{
				this.Web.DownloadFileCompleted += new AsyncCompletedEventHandler(this.Web_DownloadCompleted);
				this.Label.Text = "กำลังเปิดโปรแกรม...";
			}
			catch
			{
				this.Label.Text = "การเชื่อมต่อล้มเหลว...";
				if (MessageBox.Show("การเชื่อมต่อกับเซิร์ฟเวอร์ล้มเหลว", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
				{
					base.Close();
					base.Dispose();
				}
				this.Logger(string.Concat("# ", Modul.Name, " Status - การเชื่อมต่อกับเซิร์ฟเวอร์ล้มเหลว"));
				string name = Modul.Name;
				DateTime now = DateTime.Now;
				this.Logger(string.Concat(name, " End - ", now.ToString("yyyy-MM-dd HH-mm-ss")));
			}
		}

		private void Check()
		{
			DateTime now;
			if (this.Flag)
			{
				try
				{
					WebClient webClient = new WebClient();
					int num = int.Parse(this.Web.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=status")));
					int num1 = int.Parse(this.Web.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=version")));
					string str = this.Web.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=text"));
					if (num1 != Modul.Version)
					{
						this.Label.Text = "กรุณาอัพเดทรันเชอร์ !!";
						if (MessageBox.Show("กรุณาอัพเดทรันเชอร์ !!", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
						{
							base.Close();
							base.Dispose();
						}
					}
					if (num == 1)
					{
						this.Start.RunWorkerAsync();
					}
					else if (num == 0)
					{
						this.Label.Text = "ไม่สามารถเข้าเกมได้ในขณะนี้...";
						if (MessageBox.Show("ไม่สามารถเข้าเกมได้ในขณะนี้.", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
						{
							base.Close();
							base.Dispose();
						}
						this.Logger(string.Concat("# ", Modul.Name, " Status - ไม่สามารถเข้าเกมได้ในขณะนี้"));
						now = DateTime.Now;
						this.Logger(string.Concat("PBLauncher End - ", now.ToString("yyyy-MM-dd HH-mm-ss")));
					}
					else if (num == 2)
					{
						this.Label.Text = "เซิร์ฟเวอร์ปิดปรับปรุง...";
						if (MessageBox.Show(str.ToString(), Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
						{
							base.Close();
							base.Dispose();
						}
						this.Logger(string.Concat("# ", Modul.Name, " Status - ", str.ToString()));
						string name = Modul.Name;
						now = DateTime.Now;
						this.Logger(string.Concat(name, " End - ", now.ToString("yyyy-MM-dd HH-mm-ss")));
					}
				}
				catch
				{
					this.Label.Text = "ไม่สามารถเชื่อมต่อกับเซิร์ฟเวอร์ได้...";
					if (MessageBox.Show("ไม่สามารถเชื่อมต่อกับเซิร์ฟเวอร์ได้.", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
					{
						base.Close();
						base.Dispose();
					}
					this.Logger(string.Concat("# ", Modul.Name, " Status - ไม่สามารถเชื่อมต่อกับเซิร์ฟเวอร์ได้."));
					string name1 = Modul.Name;
					now = DateTime.Now;
					this.Logger(string.Concat(name1, " End - ", now.ToString("yyyy-MM-dd HH-mm-ss")));
				}
			}
		}

		private void Connection_Load(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			this.Processos = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
			if (!(new Computer()).FileSystem.FileExists(string.Concat(Application.StartupPath, "\\", Modul.Name, ".log")))
			{
				(new StreamWriter(string.Concat(Application.StartupPath, "\\", Modul.Name, ".log"))).Close();
			}
			this.Logger("");
			this.Logger("");
			this.Logger("");
			string name = Modul.Name;
			DateTime now = DateTime.Now;
			this.Logger(string.Concat(name, " Start - ", now.ToString("yyyy-MM-dd HH-mm-ss")));
			this.Logger(string.Concat("## ", Modul.Name, " Ver ", PointBlank.Launcher.Version.getVersion().ToString()));
			if ((int)this.Processos.Length <= 1)
			{
				Process[] processArray = processes;
				for (int i = 0; i < (int)processArray.Length; i++)
				{
					Process process = processArray[i];
					if (Operators.CompareString(process.ProcessName, "PointBlank", false) == 0)
					{
						process.Kill();
						MessageBox.Show("ปิดเกมก่อนเปิดตัวเข้าเกมส์!", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
					}
				}
			}
			else
			{
				if (MessageBox.Show(string.Concat("ไม่สามารถเปิด ", Modul.Name, " ได้สองโปรแกรม!"), Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
				{
					base.Close();
					base.Dispose();
				}
				this.Flag = false;
			}
			this.Check();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PointBlank.Launcher.Connection));
			this.Label = new System.Windows.Forms.Label();
			this.Start = new BackgroundWorker();
			base.SuspendLayout();
			this.Label.BackColor = Color.Transparent;
			this.Label.Location = new Point(1, 9);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(264, 21);
			this.Label.TabIndex = 0;
			this.Label.TextAlign = ContentAlignment.MiddleCenter;
			this.Label.Click += new EventHandler(this.Label_Click);
			this.Start.WorkerReportsProgress = true;
			this.Start.DoWork += new DoWorkEventHandler(this.Start_DoWork);
			this.Start.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Start_RunWorkerCompleted);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Resources.Start_BG;
			base.ClientSize = new System.Drawing.Size(266, 42);
			base.Controls.Add(this.Label);
			this.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Connection";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = Modul.Name;
			base.Load += new EventHandler(this.Connection_Load);
			base.ResumeLayout(false);
		}

		private void Label_Click(object sender, EventArgs e)
		{
		}

		private void Logger(string texto)
		{
			string str = string.Concat(Application.StartupPath, "\\", Modul.Name, ".log");
			DateTime now = DateTime.Now;
			StreamWriter streamWriter = new StreamWriter(str, true);
			streamWriter.WriteLine(texto);
			streamWriter.Flush();
			streamWriter.Close();
		}

		public void Start_DoWork(object sender, DoWorkEventArgs e)
		{
			this.Label.Text = "กรุณารอสักครู่...";
			Thread.Sleep(0);
		}

		public void Start_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			base.DialogResult = System.Windows.Forms.DialogResult.OK;
			base.Close();
		}

		private void Web_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			if (e.Error == null)
			{
				base.ShowInTaskbar = false;
				base.Visible = false;
			}
		}
	}
}