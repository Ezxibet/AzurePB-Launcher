using Ionic.Zip;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;
using PointBlank.DLL;
using PointBlank.DLL.Modul;
using PointBlank.DLL.Xml;
using PointBlank.Launcher.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace PointBlank.Launcher
{
	public class Launcher : Form
	{
		public PointBlank.Launcher.Connection Connection;

		public WebClient GameUpdate;

		public Microsoft.VisualBasic.Devices.Computer Computer;

		public WebClient Web;

		private PointBlank.DLL.AuthModul AuthModul;

		private bool Value = true;

		private CookieContainer Cookie = null;

		private string token = "";

		private string HWIDs = "";

		private bool @value = true;

		private Process[] processes = Process.GetProcesses();

		private IContainer components = null;

		private PictureBox ArchiveBar;

		private System.Windows.Forms.Label FileName;

		private System.Windows.Forms.Label Label;

		private System.Windows.Forms.Label Label_File;

		private System.Windows.Forms.Label Label_Version;

		private Point NewPoint;

		private PictureBox Exit;

		private PictureBox Minimize;

		private System.Windows.Forms.Timer Timer;

		private PictureBox TotalBar;

		private Button Start;

		private BackgroundWorker BackGroundWorker;

		private Button UpdatePatch;

		private Button btn_login;

		private TextBox txt_pass;

		private TextBox txt_user;

		private Panel pn_load;

		private Button btn_reg;

		private System.Windows.Forms.Label lebel_login;

		private System.Windows.Forms.Label Label_Total;

		public Launcher(PointBlank.Launcher.Connection Connection, PointBlank.DLL.AuthModul AuthModul)
		{
			this.GameUpdate = new WebClient();
			this.Computer = new Microsoft.VisualBasic.Devices.Computer();
			this.Web = new WebClient();
			this.Connection = Connection;
			this.AuthModul = AuthModul;
			this.InitializeComponent();
		}

		public void Bar1SetProgress(long received, long maximum, bool progress)
		{
			this.ArchiveBar.Width = (int)(received * (long)463 / maximum);
		}

		public void Bar2SetProgress(ulong received, ulong maximum)
		{
			this.TotalBar.Width = (int)(received * (long)463 / maximum);
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			this.lebel_login.Visible = true;
			this.lebel_login.Text = "Por favor aguarde...";
			string str = this.PerformRequest(string.Concat(Modul.WEB, "launcher/send.php"), this.txt_user.Text, this.txt_pass.Text, this.GetMacAddress(), this.GetcpuInfo(), this.GetHDD(), this.GetboardInfo());
			if (str == "Fail")
			{
				this.lebel_login.Text = "O ID ou senha incorreto.";
				this.txt_pass.Text = "";
				this.txt_user.Text = "";
				this.txt_user.Focus();
			}
			else if (str == "Update")
			{
				this.lebel_login.Text = "Atualize";
				this.txt_pass.Text = "";
				this.txt_user.Text = "";
				this.txt_user.Focus();
			}
			else if (str == "Ban")
			{
				this.lebel_login.Text = "Sua conta foi banida.";
				this.txt_pass.Text = "";
				this.txt_user.Text = "";
				this.txt_user.Focus();
			}
			else if (str != "BanHWID")
			{
				this.token = str;
				this.BackgroundImage = Resources.bg_update;
				this.lebel_login.Visible = false;
				this.txt_user.Visible = false;
				this.txt_pass.Visible = false;
				this.btn_login.Visible = false;
				this.btn_reg.Visible = false;
				this.pn_load.Visible = true;
				this.Start.Visible = true;
			}
			else
			{
				this.lebel_login.Text = "O seu dispositivo foi banido.";
				this.txt_pass.Text = "";
				this.txt_user.Text = "";
				this.txt_user.Focus();
			}
		}

		private void btn_login_MouseLeave(object sender, EventArgs e)
		{
			this.btn_login.BackgroundImage = Resources.btn_lg3;
		}

		private void btn_login_MouseMove(object sender, MouseEventArgs e)
		{
			this.btn_login.BackgroundImage = Resources.btn_lghv;
		}

		private void btn_reg_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Por favor, registre-se apenas através do site.", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
		}

		private void button1_Click_3(object sender, EventArgs e)
		{
		}

		private void button1_Click_4(object sender, EventArgs e)
		{
		}

		private void button1_Click_5(object sender, EventArgs e)
		{
		}

		private void Check_MouseLeave(object sender, EventArgs e)
		{
		}

		private void Check_MouseMove(object sender, MouseEventArgs e)
		{
		}

		private void Closed_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void Closed_MouseLeave(object sender, EventArgs e)
		{
			this.Exit.Image = Resources.Closed_Normal;
			this.Exit.BackColor = Color.Transparent;
		}

		private void Closed_MouseMove(object sender, EventArgs e)
		{
			this.Exit.Image = Resources.Closed_Over;
			this.Exit.BackColor = Color.Transparent;
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form_Closing(object sender, FormClosingEventArgs e)
		{
			if (!this.Value)
			{
				Environment.Exit(0);
			}
			else if (e.CloseReason != System.Windows.Forms.CloseReason.UserClosing)
			{
				e.Cancel = this.Value;
			}
			else if (MessageBox.Show("Deseja fechar o programa??", Modul.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
			{
				e.Cancel = this.Value;
			}
			else
			{
				DateTime now = DateTime.Now;
				this.Logger(string.Concat("PBLauncher End - ", now.ToString("yyyy-MM-dd HH-mm-ss")));
				Environment.Exit(0);
			}
		}

		private void GameUpdate_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			try
			{
				if (e.Error == null)
				{
					int num = int.Parse(File.ReadAllText(string.Concat(Application.StartupPath, "\\", Modul.Ver)));
					int num1 = num + 1;
					this.ArchiveBar.Width = 0;
					this.Unzip(Application.StartupPath, string.Concat(new object[] { Application.StartupPath, "\\_DownloadPatchFiles\\UpdatePatch_Client_", num1, ".zip" }));
					this.Timer.Start();
					Directory.Delete(string.Concat(Application.StartupPath, "\\_DownloadPatchFiles"), true);
					this.ArchiveBar.Width = 463;
				}
			}
			catch
			{
				MessageBox.Show("Ocorreu um erro desconhecido.. Por favor tente novamente mais tarde....", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
			}
		}

		private void GameUpdate_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.Bar1SetProgress(e.BytesReceived, e.TotalBytesToReceive, false);
		}

		private string GetboardInfo()
		{
			string empty = string.Empty;
			foreach (ManagementObject managementObject in (new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard")).Get())
			{
				empty = managementObject.GetPropertyValue("SerialNumber").ToString();
			}
			return empty;
		}

		private string GetcpuInfo()
		{
			string empty = string.Empty;
			foreach (ManagementObject managementObject in (new ManagementObjectSearcher("SELECT * FROM Win32_Processor")).Get())
			{
				empty = managementObject.GetPropertyValue("ProcessorId").ToString();
			}
			return empty;
		}

		private long GetFileSize(string FilePath)
		{
			long num;
			num = (!File.Exists(FilePath) ? (long)0 : (new FileInfo(FilePath)).Length);
			return num;
		}

		public static List<string> GetFilesRecursive(string Initial, string[] Extension)
		{
			List<string> strs = new List<string>();
			Stack<string> strs1 = new Stack<string>();
			strs1.Push(Initial);
			while (strs1.Count > 0)
			{
				try
				{
					string str = strs1.Pop();
					string[] extension = Extension;
					for (int i = 0; i < (int)extension.Length; i++)
					{
						string str1 = extension[i];
						strs.AddRange(Directory.GetFiles(str, (str1.Substring(0, 1) != "*" ? string.Concat("*", str1) : str1)));
					}
					string[] directories = Directory.GetDirectories(str);
					for (int j = 0; j < (int)directories.Length; j++)
					{
						strs1.Push(directories[j]);
					}
				}
				catch
				{
					MessageBox.Show("Ocorreu um erro desconhecido.. Por favor tente novamente mais tarde....", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
				}
			}
			return strs;
		}

		private string GetHDD()
		{
			string empty = string.Empty;
			foreach (ManagementObject managementObject in (new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")).Get())
			{
				if (managementObject["SerialNumber"] != null)
				{
					empty = managementObject["SerialNumber"].ToString();
				}
				else
				{
					empty = null;
				}
			}
			return empty;
		}

		private string GetMacAddress()
		{
			string empty = string.Empty;
			long speed = (long)-1;
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			for (int i = 0; i < (int)allNetworkInterfaces.Length; i++)
			{
				NetworkInterface networkInterface = allNetworkInterfaces[i];
				string str = networkInterface.GetPhysicalAddress().ToString();
				if ((networkInterface.Speed <= speed || string.IsNullOrEmpty(str) ? false : str.Length >= 12))
				{
					speed = networkInterface.Speed;
					empty = str;
				}
			}
			return empty;
		}

		protected string GetMD5HashFromFile(string fileName)
		{
			string str;
			using (MD5 mD5 = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(fileName))
				{
					str = BitConverter.ToString(mD5.ComputeHash(fileStream)).Replace("-", string.Empty);
				}
			}
			return str;
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PointBlank.Launcher.Launcher));
			this.Label = new System.Windows.Forms.Label();
			this.Label_File = new System.Windows.Forms.Label();
			this.Label_Total = new System.Windows.Forms.Label();
			this.Label_Version = new System.Windows.Forms.Label();
			this.Exit = new PictureBox();
			this.TotalBar = new PictureBox();
			this.ArchiveBar = new PictureBox();
			this.FileName = new System.Windows.Forms.Label();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.Minimize = new PictureBox();
			this.BackGroundWorker = new BackgroundWorker();
			this.Start = new Button();
			this.UpdatePatch = new Button();
			this.txt_pass = new TextBox();
			this.txt_user = new TextBox();
			this.btn_login = new Button();
			this.btn_reg = new Button();
			this.pn_load = new Panel();
			this.lebel_login = new System.Windows.Forms.Label();
			((ISupportInitialize)this.Exit).BeginInit();
			((ISupportInitialize)this.TotalBar).BeginInit();
			((ISupportInitialize)this.ArchiveBar).BeginInit();
			((ISupportInitialize)this.Minimize).BeginInit();
			this.pn_load.SuspendLayout();
			base.SuspendLayout();
			this.Label.BackColor = Color.Transparent;
			this.Label.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 222);
			this.Label.ForeColor = Color.Transparent;
			this.Label.Location = new Point(16, 526);
			this.Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(465, 16);
			this.Label.TabIndex = 0;
			this.Label.Text = " ";
			this.Label.MouseDown += new MouseEventHandler(this.Launcher_MouseDown);
			this.Label.MouseMove += new MouseEventHandler(this.Launcher_MouseMove);
			this.Label_File.BackColor = Color.Transparent;
			this.Label_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
			this.Label_File.ForeColor = Color.Transparent;
			this.Label_File.Location = new Point(8, -1);
			this.Label_File.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label_File.Name = "Label_File";
			this.Label_File.Size = new System.Drawing.Size(38, 16);
			this.Label_File.TabIndex = 1;
			this.Label_File.MouseDown += new MouseEventHandler(this.Launcher_MouseDown);
			this.Label_File.MouseMove += new MouseEventHandler(this.Launcher_MouseMove);
			this.Label_Total.BackColor = Color.Transparent;
			this.Label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
			this.Label_Total.ForeColor = Color.Transparent;
			this.Label_Total.Location = new Point(8, 31);
			this.Label_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label_Total.Name = "Label_Total";
			this.Label_Total.Size = new System.Drawing.Size(465, 16);
			this.Label_Total.TabIndex = 2;
			this.Label_Total.Text = " ";
			this.Label_Total.MouseDown += new MouseEventHandler(this.Launcher_MouseDown);
			this.Label_Total.MouseMove += new MouseEventHandler(this.Launcher_MouseMove);
			this.Label_Version.BackColor = Color.Transparent;
			this.Label_Version.ForeColor = Color.White;
			this.Label_Version.Location = new Point(262, 7);
			this.Label_Version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label_Version.Name = "Label_Version";
			this.Label_Version.Size = new System.Drawing.Size(471, 13);
			this.Label_Version.TabIndex = 3;
			this.Label_Version.MouseDown += new MouseEventHandler(this.Launcher_MouseDown);
			this.Label_Version.MouseMove += new MouseEventHandler(this.Launcher_MouseMove);
			this.Exit.BackColor = Color.White;
			this.Exit.BackgroundImage = Resources.Closed_Normal;
			this.Exit.Location = new Point(754, 3);
			this.Exit.Margin = new System.Windows.Forms.Padding(2);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(23, 23);
			this.Exit.TabIndex = 4;
			this.Exit.TabStop = false;
			this.Exit.Click += new EventHandler(this.Closed_Click);
			this.Exit.MouseEnter += new EventHandler(this.Closed_MouseMove);
			this.Exit.MouseLeave += new EventHandler(this.Closed_MouseLeave);
			this.TotalBar.BackColor = Color.Lime;
			this.TotalBar.Location = new Point(10, 50);
			this.TotalBar.Name = "TotalBar";
			this.TotalBar.Size = new System.Drawing.Size(540, 10);
			this.TotalBar.TabIndex = 10;
			this.TotalBar.TabStop = false;
			this.TotalBar.MouseDown += new MouseEventHandler(this.Launcher_MouseDown);
			this.TotalBar.MouseMove += new MouseEventHandler(this.Launcher_MouseMove);
			this.ArchiveBar.BackColor = Color.Lime;
			this.ArchiveBar.Location = new Point(9, 18);
			this.ArchiveBar.Name = "ArchiveBar";
			this.ArchiveBar.Size = new System.Drawing.Size(541, 10);
			this.ArchiveBar.TabIndex = 11;
			this.ArchiveBar.TabStop = false;
			this.ArchiveBar.MouseDown += new MouseEventHandler(this.Launcher_MouseDown);
			this.ArchiveBar.MouseMove += new MouseEventHandler(this.Launcher_MouseMove);
			this.FileName.BackColor = Color.Transparent;
			this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
			this.FileName.ForeColor = Color.Transparent;
			this.FileName.Location = new Point(51, 1);
			this.FileName.Name = "FileName";
			this.FileName.Size = new System.Drawing.Size(422, 16);
			this.FileName.TabIndex = 100;
			this.FileName.Text = " ";
			this.FileName.Visible = false;
			this.FileName.MouseDown += new MouseEventHandler(this.Launcher_MouseDown);
			this.FileName.MouseMove += new MouseEventHandler(this.Launcher_MouseMove);
			this.Timer.Tick += new EventHandler(this.Timer_Tick);
			this.Minimize.BackColor = Color.White;
			this.Minimize.BackgroundImage = Resources.Hide_Normal;
			this.Minimize.Location = new Point(726, 3);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(23, 23);
			this.Minimize.TabIndex = 15;
			this.Minimize.TabStop = false;
			this.Minimize.Click += new EventHandler(this.Minimize_Click);
			this.Minimize.MouseLeave += new EventHandler(this.Minimize_MouseLeave);
			this.Minimize.MouseMove += new MouseEventHandler(this.Minimize_MouseMove);
			this.Start.BackgroundImage = Resources.btn_stl;
			this.Start.FlatAppearance.BorderSize = 0;
			this.Start.FlatStyle = FlatStyle.Flat;
			this.Start.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold);
			this.Start.ForeColor = Color.FromArgb(20, 32, 45);
			this.Start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Start.Location = new Point(582, 533);
			this.Start.Margin = new System.Windows.Forms.Padding(0);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(179, 67);
			this.Start.TabIndex = 0;
			this.Start.TabStop = false;
			this.Start.Visible = false;
			this.Start.Click += new EventHandler(this.Start_Click);
			this.Start.MouseLeave += new EventHandler(this.Start_MouseLeave);
			this.Start.MouseMove += new MouseEventHandler(this.Start_MouseMove);
			this.UpdatePatch.BackColor = Color.Transparent;
			this.UpdatePatch.BackgroundImage = Resources.btn_ud6;
			this.UpdatePatch.Enabled = false;
			this.UpdatePatch.FlatAppearance.BorderSize = 0;
			this.UpdatePatch.FlatStyle = FlatStyle.Flat;
			this.UpdatePatch.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold);
			this.UpdatePatch.ForeColor = Color.FromArgb(20, 32, 45);
			this.UpdatePatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.UpdatePatch.Location = new Point(307, 464);
			this.UpdatePatch.Margin = new System.Windows.Forms.Padding(0);
			this.UpdatePatch.Name = "UpdatePatch";
			this.UpdatePatch.Size = new System.Drawing.Size(174, 64);
			this.UpdatePatch.TabIndex = 1001;
			this.UpdatePatch.TabStop = false;
			this.UpdatePatch.UseVisualStyleBackColor = false;
			this.UpdatePatch.Visible = false;
			this.UpdatePatch.Click += new EventHandler(this.UpdatePatch_Click);
			this.UpdatePatch.MouseLeave += new EventHandler(this.UpdatePatch_MouseLeave);
			this.UpdatePatch.MouseMove += new MouseEventHandler(this.UpdatePatch_MouseMove);
			this.txt_pass.BackColor = Color.White;
			this.txt_pass.BorderStyle = BorderStyle.None;
			this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
			this.txt_pass.ForeColor = Color.Black;
			this.txt_pass.Location = new Point(216, 421);
			this.txt_pass.Multiline = true;
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.PasswordChar = '*';
			this.txt_pass.Size = new System.Drawing.Size(343, 16);
			this.txt_pass.TabIndex = 1004;
			this.txt_pass.TextChanged += new EventHandler(this.txt_pass_TextChanged);
			this.txt_pass.KeyDown += new KeyEventHandler(this.txt_pass_KeyDown);
			this.txt_user.BackColor = Color.White;
			this.txt_user.BorderStyle = BorderStyle.None;
			this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.txt_user.ForeColor = Color.Black;
			this.txt_user.Location = new Point(216, 358);
			this.txt_user.Multiline = true;
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(343, 17);
			this.txt_user.TabIndex = 1003;
			this.txt_user.TextChanged += new EventHandler(this.txt_user_TextChanged);
			this.btn_login.BackColor = Color.Transparent;
			this.btn_login.BackgroundImage = Resources.btn_lg3;
			this.btn_login.FlatAppearance.BorderSize = 0;
			this.btn_login.FlatStyle = FlatStyle.Flat;
			this.btn_login.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold);
			this.btn_login.ForeColor = Color.FromArgb(20, 32, 45);
			this.btn_login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btn_login.Location = new Point(335, 462);
			this.btn_login.Margin = new System.Windows.Forms.Padding(0);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(110, 60);
			this.btn_login.TabIndex = 1003;
			this.btn_login.TabStop = false;
			this.btn_login.UseVisualStyleBackColor = false;
			this.btn_login.Click += new EventHandler(this.btn_login_Click);
			this.btn_login.MouseLeave += new EventHandler(this.btn_login_MouseLeave);
			this.btn_login.MouseMove += new MouseEventHandler(this.btn_login_MouseMove);
			this.btn_reg.BackColor = Color.Transparent;
			this.btn_reg.BackgroundImage = Resources.btn_regl;
			this.btn_reg.FlatAppearance.BorderSize = 0;
			this.btn_reg.FlatStyle = FlatStyle.Flat;
			this.btn_reg.Font = new System.Drawing.Font("Arial", 12f, FontStyle.Bold);
			this.btn_reg.ForeColor = Color.FromArgb(20, 32, 45);
			this.btn_reg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btn_reg.Location = new Point(353, 518);
			this.btn_reg.Margin = new System.Windows.Forms.Padding(0);
			this.btn_reg.Name = "btn_reg";
			this.btn_reg.Size = new System.Drawing.Size(78, 22);
			this.btn_reg.TabIndex = 1008;
			this.btn_reg.TabStop = false;
			this.btn_reg.UseVisualStyleBackColor = false;
			this.btn_reg.Click += new EventHandler(this.btn_reg_Click);
			this.btn_reg.MouseLeave += new EventHandler(this.btn_login_MouseLeave);
			this.btn_reg.MouseMove += new MouseEventHandler(this.btn_login_MouseMove);
			this.pn_load.BackColor = Color.Transparent;
			this.pn_load.Controls.Add(this.FileName);
			this.pn_load.Controls.Add(this.Label_Total);
			this.pn_load.Controls.Add(this.Label_File);
			this.pn_load.Controls.Add(this.ArchiveBar);
			this.pn_load.Controls.Add(this.TotalBar);
			this.pn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
			this.pn_load.Location = new Point(29, 531);
			this.pn_load.Name = "pn_load";
			this.pn_load.Size = new System.Drawing.Size(558, 67);
			this.pn_load.TabIndex = 1006;
			this.pn_load.Visible = false;
			this.lebel_login.BackColor = Color.Transparent;
			this.lebel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lebel_login.ForeColor = Color.Yellow;
			this.lebel_login.Location = new Point(303, 329);
			this.lebel_login.Name = "lebel_login";
			this.lebel_login.Size = new System.Drawing.Size(222, 21);
			this.lebel_login.TabIndex = 101;
			this.lebel_login.Text = " ";
			this.lebel_login.Visible = false;
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = Resources.bg_update;
			base.ClientSize = new System.Drawing.Size(783, 652);
			base.Controls.Add(this.lebel_login);
			base.Controls.Add(this.pn_load);
			base.Controls.Add(this.btn_login);
			base.Controls.Add(this.btn_reg);
			base.Controls.Add(this.txt_pass);
			base.Controls.Add(this.txt_user);
			base.Controls.Add(this.Start);
			base.Controls.Add(this.Minimize);
			base.Controls.Add(this.Exit);
			base.Controls.Add(this.Label_Version);
			base.Controls.Add(this.Label);
			base.Controls.Add(this.UpdatePatch);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5f);
			this.ForeColor = Color.Transparent;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new System.Windows.Forms.Padding(2);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Launcher";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "PBLauncher";
			base.FormClosing += new FormClosingEventHandler(this.Form_Closing);
			base.Load += new EventHandler(this.Launcher_Load);
			base.MouseDown += new MouseEventHandler(this.Launcher_MouseDown);
			base.MouseMove += new MouseEventHandler(this.Launcher_MouseMove);
			((ISupportInitialize)this.Exit).EndInit();
			((ISupportInitialize)this.TotalBar).EndInit();
			((ISupportInitialize)this.ArchiveBar).EndInit();
			((ISupportInitialize)this.Minimize).EndInit();
			this.pn_load.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public void Launcher_Load(object sender, EventArgs e)
		{
			PrivateFontCollection privateFontCollection = new PrivateFontCollection();
			privateFontCollection.AddFontFile(string.Concat(Directory.GetCurrentDirectory(), "\\Font\\PrintAble4U.ttf"));
			foreach (Control control in base.Controls)
			{
				control.Font = new System.Drawing.Font(privateFontCollection.Families[0], 15f, FontStyle.Bold);
			}
			this.Cookie = new CookieContainer();
			this.SearchFileExtension();
			this.BackgroundImage = Resources.back_login;
			base.KeyPreview = true;
			int num = int.Parse(this.Web.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=button")));
			this.Label_File.Text = "O arquivo";
			this.Label_Total.Text = "Todos os";
			base.WindowState = FormWindowState.Normal;
			base.Visible = true;
			this.Label_Version.Visible = false;
			this.Start.Visible = true;
			LauncherModul.LastVersion = int.Parse(this.Web.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=last_client_version")));
			this.Label_Version.Text = string.Concat("Versão do patch: ", File.ReadAllText(string.Concat(Application.StartupPath, "\\", Modul.Ver)), "/", LauncherModul.LastVersion.ToString());
			this.Start.Enabled = false;
			if (this.Computer.FileSystem.DirectoryExists(string.Concat(Application.StartupPath, "\\_LauncherPatchFiles")))
			{
				this.Computer.FileSystem.DeleteDirectory(string.Concat(Application.StartupPath, "\\_LauncherPatchFiles"), DeleteDirectoryOption.DeleteAllContents);
			}
			if (num == 1)
			{
				this.Start.Enabled = true;
			}
			else if (num == 2)
			{
				this.Start.BackgroundImage = Resources.Start_Disable;
				this.Start.Enabled = false;
			}
			else if (num == 3)
			{
				this.Start.Enabled = true;
			}
			else if (num == 4)
			{
				this.Start.Enabled = true;
			}
			this.pn_load.Visible = false;
			this.Start.Visible = false;
			if (LauncherModul.LastVersion.ToString() == File.ReadAllText(string.Concat(Application.StartupPath, "\\", Modul.Ver)))
			{
				this.XmlLoad();
			}
			else if (LauncherModul.LastVersion >= int.Parse(File.ReadAllText(string.Concat(Application.StartupPath, "\\", Modul.Ver))))
			{
				this.Value = true;
				this.ArchiveBar.Width = 0;
				this.TotalBar.Width = 0;
				this.BackgroundImage = Resources.back_starting;
				this.txt_user.Visible = false;
				this.txt_pass.Visible = false;
				this.btn_login.Visible = false;
				this.btn_reg.Visible = false;
				this.pn_load.Visible = false;
				this.Start.Visible = false;
				this.Start.Visible = false;
				this.Start.Enabled = true;
				this.UpdatePatch.Enabled = true;
				this.UpdatePatch.Visible = true;
			}
			else
			{
				int num1 = 0;
				File.WriteAllText(string.Concat(Application.StartupPath, "\\", Modul.Ver), num1.ToString());
				this.Value = true;
				this.ArchiveBar.Width = 0;
				this.TotalBar.Width = 0;
				this.BackgroundImage = Resources.back_starting;
				this.txt_user.Visible = false;
				this.txt_pass.Visible = false;
				this.btn_login.Visible = false;
				this.btn_reg.Visible = false;
				this.pn_load.Visible = false;
				this.Start.Visible = false;
				this.Start.Visible = false;
				this.Start.Enabled = true;
				this.UpdatePatch.Enabled = true;
				this.UpdatePatch.Visible = true;
			}
		}

		private void Launcher_MouseDown(object sender, MouseEventArgs e)
		{
			if (Control.MouseButtons == System.Windows.Forms.MouseButtons.Left)
			{
				int left = base.Left;
				Point mousePosition = Control.MousePosition;
				this.NewPoint.X = left - mousePosition.X;
				int top = base.Top;
				mousePosition = Control.MousePosition;
				this.NewPoint.Y = top - mousePosition.Y;
			}
		}

		private void Launcher_MouseMove(object sender, MouseEventArgs e)
		{
			if (Control.MouseButtons == System.Windows.Forms.MouseButtons.Left)
			{
				int x = this.NewPoint.X;
				Point mousePosition = Control.MousePosition;
				base.Left = x + mousePosition.X;
				int y = this.NewPoint.Y;
				mousePosition = Control.MousePosition;
				base.Top = y + mousePosition.Y;
			}
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr LoadLibrary(string dllName);

		private void Logger(string Text)
		{
			string str = string.Concat(Application.StartupPath, "\\PBLauncher.log");
			DateTime now = DateTime.Now;
			StreamWriter streamWriter = new StreamWriter(str, true);
			streamWriter.WriteLine(Text);
			streamWriter.Flush();
			streamWriter.Close();
		}

		private void Minimize_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void Minimize_MouseLeave(object sender, EventArgs e)
		{
			this.Minimize.BackgroundImage = Resources.Hide_Normal;
			this.Minimize.BackColor = Color.Transparent;
		}

		private void Minimize_MouseMove(object sender, MouseEventArgs e)
		{
			this.Minimize.BackgroundImage = Resources.Hide_Over;
			this.Minimize.BackColor = Color.Transparent;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{
		}

		private List<XMLModel> Parse(string Path)
		{
			List<XMLModel> xMLModels = new List<XMLModel>();
			XmlDocument xmlDocument = new XmlDocument();
			FileStream fileStream = new FileStream(Path, FileMode.Open);
			if (fileStream.Length != (long)0)
			{
				try
				{
					xmlDocument.Load(fileStream);
					for (XmlNode i = xmlDocument.FirstChild; i != null; i = i.NextSibling)
					{
						if ("List".Equals(i.Name))
						{
							for (XmlNode j = i.FirstChild; j != null; j = j.NextSibling)
							{
								if ("File".Equals(j.Name))
								{
									XmlNamedNodeMap attributes = j.Attributes;
									xMLModels.Add(new XMLModel(attributes.GetNamedItem("Name").Value));
								}
							}
						}
					}
				}
				catch (XmlException xmlException)
				{
					MessageBox.Show(xmlException.ToString());
				}
			}
			else
			{
				this.Logger("[ERROR] CODE PAUSE");
			}
			fileStream.Dispose();
			fileStream.Close();
			return xMLModels;
		}

		private string PerformRequest(string url, string username, string password, string mac, string cpuinfo, string hddserial, string boardid)
		{
			HttpWebRequest cookie = (HttpWebRequest)WebRequest.Create(url);
			cookie.CookieContainer = this.Cookie;
			string str = string.Concat(new string[] { "username=", username, "&password=", password, "&mac=", mac, "&cpuinfo=", cpuinfo, "&hddserial=", hddserial, "&boardserial=", boardid, "&Hash=", this.GetMD5HashFromFile(string.Concat(Process.GetCurrentProcess().ProcessName, ".exe")) });
			byte[] bytes = Encoding.UTF8.GetBytes(str);
			cookie.Method = "POST";
			cookie.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
			cookie.ContentLength = (long)((int)bytes.Length);
			using (Stream requestStream = cookie.GetRequestStream())
			{
				requestStream.Write(bytes, 0, (int)bytes.Length);
			}
			WebResponse response = (HttpWebResponse)cookie.GetResponse();
			return (new StreamReader(response.GetResponseStream())).ReadToEnd();
		}

		public void SearchFileExtension()
		{
			try
			{
				string[] strArrays = new string[] { "*.tmp", "*.PendingOverwrite" };
				foreach (string filesRecursive in PointBlank.Launcher.Launcher.GetFilesRecursive(Application.StartupPath, strArrays))
				{
					File.Delete(filesRecursive);
				}
			}
			catch
			{
				MessageBox.Show("Ocorreu um erro desconhecido.. Por favor tente novamente mais tarde....", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
			}
		}

		private void Start_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(string.Concat(Application.StartupPath, "\\PointBlank.exe"), string.Concat(" /GameID: NProject /Token: ", this.token));
				Process[] processArray = this.processes;
				for (int i = 0; i < (int)processArray.Length; i++)
				{
					Process process = processArray[i];
					if (Operators.CompareString(process.ProcessName, Process.GetCurrentProcess().ProcessName, false) == 0)
					{
						process.Kill();
						MessageBox.Show("Feche o jogo antes de iniciar o jogo!", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
					}
				}
			}
			catch
			{
				Thread.Sleep(2000);
				Process.Start(string.Concat(Application.StartupPath, "\\PointBlank.exe"), string.Concat(" /GameID: NProject /Token: ", this.token));
				Process[] processArray1 = this.processes;
				for (int j = 0; j < (int)processArray1.Length; j++)
				{
					Process process1 = processArray1[j];
					if (Operators.CompareString(process1.ProcessName, Process.GetCurrentProcess().ProcessName, false) == 0)
					{
						process1.Kill();
						MessageBox.Show("Feche o jogo antes de iniciar o jogo!", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
					}
				}
			}
		}

		private void Start_MouseLeave(object sender, EventArgs e)
		{
			this.Start.BackgroundImage = Resources.btn_stl;
		}

		private void Start_MouseMove(object sender, MouseEventArgs e)
		{
			this.Start.BackgroundImage = Resources.btn_stlh;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			try
			{
				LauncherModul.LastVersion = int.Parse(this.Web.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=last_client_version")));
				if (LauncherModul.LastVersion != int.Parse(File.ReadAllText(string.Concat(Application.StartupPath, "\\", Modul.Ver))))
				{
					this.Value = true;
					int num = int.Parse(File.ReadAllText(string.Concat(Application.StartupPath, "\\", Modul.Ver))) + 1;
					this.Computer.FileSystem.CreateDirectory(string.Concat(Application.StartupPath, "\\_DownloadPatchFiles"));
					try
					{
						this.GameUpdate.DownloadFileAsync(new Uri(string.Concat(Modul.WEB, "update/client/UpdatePatch_Client_", num.ToString(), ".zip")), string.Concat(new object[] { Application.StartupPath, "\\_DownloadPatchFiles\\UpdatePatch_Client_", num, ".zip" }));
					}
					catch
					{
						MessageBox.Show("Ocorreu um erro desconhecido.. Por favor tente novamente mais tarde....", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
						this.Logger("[ERROR] CODE UPDATE");
					}
					this.Bar2SetProgress((ulong)0, (ulong)100);
					this.Logger(string.Concat("# PBLauncher Download - ", num.ToString()));
					this.Timer.Stop();
				}
				else
				{
					base.KeyPreview = true;
					int num1 = int.Parse(this.Web.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=button")));
					base.Visible = true;
					this.Label_Version.Visible = false;
					this.Start.Visible = true;
					this.UpdatePatch.Visible = false;
					LauncherModul.LastVersion = int.Parse(this.Web.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=last_client_version")));
					this.Label_Version.Text = string.Concat("Versão do patch: ", File.ReadAllText(string.Concat(Application.StartupPath, "\\", Modul.Ver)), "/", LauncherModul.LastVersion.ToString());
					this.Start.Enabled = false;
					if (this.Computer.FileSystem.DirectoryExists(string.Concat(Application.StartupPath, "\\_LauncherPatchFiles")))
					{
						this.Computer.FileSystem.DeleteDirectory(string.Concat(Application.StartupPath, "\\_LauncherPatchFiles"), DeleteDirectoryOption.DeleteAllContents);
					}
					if (num1 == 1)
					{
						this.Start.Enabled = true;
					}
					else if (num1 == 2)
					{
						this.Start.BackgroundImage = Resources.Start_Disable;
						this.Start.Enabled = false;
					}
					else if (num1 == 3)
					{
						this.Start.Enabled = true;
					}
					else if (num1 == 4)
					{
						this.Start.Enabled = true;
					}
					this.XmlLoad();
					this.Timer.Stop();
				}
			}
			catch
			{
				MessageBox.Show("Ocorreu um erro desconhecido.. Por favor tente novamente mais tarde....", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
			}
		}

		private void txt_pass_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.btn_login.PerformClick();
			}
		}

		private void txt_pass_TextChanged(object sender, EventArgs e)
		{
		}

		private void txt_user_TextChanged(object sender, EventArgs e)
		{
		}

		public void Unzip(string TargetDir, string ZipToUnpack)
		{
			try
			{
				this.SearchFileExtension();
				this.Value = true;
				using (ZipFile zipFile = ZipFile.Read(ZipToUnpack))
				{
					zipFile.add_ExtractProgress(new EventHandler<ExtractProgressEventArgs>(this.Unzip_ExtractProgressChanged));
					int num = 0;
					int num1 = 0;
					foreach (ZipEntry zipEntry in zipFile)
					{
						if (!zipEntry.get_IsDirectory())
						{
							num1++;
						}
					}
					foreach (ZipEntry zipEntry1 in zipFile)
					{
						string fileName = zipEntry1.get_FileName();
						if (fileName.Contains("/"))
						{
							int num2 = fileName.LastIndexOf("/");
							fileName = fileName.Substring(num2 + 1);
						}
						if (!zipEntry1.get_IsDirectory())
						{
							if (fileName != (Modul.Ver ?? ""))
							{
								this.Logger(string.Concat("# Patch file Update Exception # FileName : ", fileName));
							}
							base.Update();
							this.Refresh();
							int num3 = num + 1;
							num = num3;
							this.Bar2SetProgress((ulong)num3, (ulong)num1);
						}
						zipEntry1.Extract(TargetDir, 1);
					}
				}
			}
			catch
			{
				MessageBox.Show("Ocorreu um erro desconhecido.. Por favor tente novamente mais tarde....", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
			}
		}

		private void Unzip_ExtractProgressChanged(object sender, ExtractProgressEventArgs e)
		{
			if (e.get_TotalBytesToTransfer() != (long)0)
			{
				this.Bar1SetProgress(e.get_BytesTransferred(), e.get_TotalBytesToTransfer(), false);
			}
			this.ArchiveBar.Refresh();
			this.ArchiveBar.Update();
		}

		private void UpdatePatch_Click(object sender, EventArgs e)
		{
			File.WriteAllBytes("UPDATE.exe", Resources.UPDATE);
			Process.Start("UPDATE.exe");
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < (int)processes.Length; i++)
			{
				Process process = processes[i];
				if (Operators.CompareString(process.ProcessName, Process.GetCurrentProcess().ProcessName, false) == 0)
				{
					process.Kill();
				}
			}
		}

		private void UpdatePatch_MouseLeave(object sender, EventArgs e)
		{
			this.UpdatePatch.BackgroundImage = Resources.btn_ud6;
		}

		private void UpdatePatch_MouseMove(object sender, MouseEventArgs e)
		{
			this.UpdatePatch.BackgroundImage = Resources.btn_ud7;
		}

		private void Verif_Click(object sender, EventArgs e)
		{
			try
			{
				this.FileName.Enabled = true;
				this.FileName.Visible = true;
				int num = int.Parse(this.GameUpdate.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=button")));
				string str = this.GameUpdate.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=check"));
				string str1 = this.GameUpdate.DownloadString(string.Concat(Modul.WEB, "launcher/status.php?act=text"));
				if (num != 1)
				{
					if (num == 2)
					{
						if (MessageBox.Show(str1.ToString(), Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.OK)
						{
							if (MessageBox.Show(str1.ToString(), Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
							{
							}
						}
						this.Logger(string.Concat("# PBLauncher Status - ", str1.ToString()));
					}
					else if (num == 3)
					{
						MessageBox.Show(str.ToString(), Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
					}
				}
			}
			catch
			{
				MessageBox.Show("Ocorreu um erro desconhecido. Por favor, tente novamente mais tarde ...", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
			}
		}

		private void webNews_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		public void XmlLoad()
		{
			try
			{
				if (File.Exists(string.Concat(Application.StartupPath, "\\Removes.xml")))
				{
					List<XMLModel> xMLModels = this.Parse(string.Concat(Application.StartupPath, "\\Removes.xml"));
					int num = 0;
					this.FileName.Visible = true;
					foreach (XMLModel xMLModel in xMLModels)
					{
						num++;
						this.Bar2SetProgress((ulong)num, (ulong)xMLModels.Count);
					}
					File.Delete(string.Concat(Application.StartupPath, "\\Removes.xml"));
					this.FileName.Visible = false;
					this.Start.Enabled = true;
					this.Start.BackgroundImage = Resources.Start_Normal;
				}
			}
			catch
			{
				MessageBox.Show("Ocorreu um erro desconhecido.. Por favor tente novamente mais tarde....", Modul.Name, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
			}
		}
	}
}