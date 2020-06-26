namespace Launcher
{
    partial class PBLauncher
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PBLauncher));
            this.ArchiveBar = new System.Windows.Forms.PictureBox();
            this.TotalBar = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Verif = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.timerDownload = new System.Windows.Forms.Timer(this.components);
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.Jogar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Veri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.total_label = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sair = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label_launcher = new System.Windows.Forms.Label();
            this.AttDetect = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Ptoken = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.Sair.SuspendLayout();
            this.AttDetect.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArchiveBar
            // 
            this.ArchiveBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(172)))), ((int)(((byte)(240)))));
            this.ArchiveBar.Location = new System.Drawing.Point(458, 643);
            this.ArchiveBar.Name = "ArchiveBar";
            this.ArchiveBar.Size = new System.Drawing.Size(463, 10);
            this.ArchiveBar.TabIndex = 0;
            this.ArchiveBar.TabStop = false;
            // 
            // TotalBar
            // 
            this.TotalBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(172)))), ((int)(((byte)(240)))));
            this.TotalBar.Location = new System.Drawing.Point(130, 643);
            this.TotalBar.Name = "TotalBar";
            this.TotalBar.Size = new System.Drawing.Size(463, 10);
            this.TotalBar.TabIndex = 1;
            this.TotalBar.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BackgroundImage = global::PBLauncher.Properties.Resources.Start_Normal;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.Start.Location = new System.Drawing.Point(693, 160);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(166, 76);
            this.Start.TabIndex = 8;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Visible = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.Start.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Start_MouseMove);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblstatus.ForeColor = System.Drawing.Color.White;
            this.lblstatus.Location = new System.Drawing.Point(11, 10);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(116, 16);
            this.lblstatus.TabIndex = 19;
            this.lblstatus.Text = "Status do launcher";
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.BackColor = System.Drawing.Color.Transparent;
            this.fileName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.fileName.ForeColor = System.Drawing.Color.White;
            this.fileName.Location = new System.Drawing.Point(237, 10);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(35, 16);
            this.fileName.TabIndex = 23;
            this.fileName.Text = ">>>";
            this.fileName.Visible = false;
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.Transparent;
            this.Button_Update.BackgroundImage = global::PBLauncher.Properties.Resources.Update_Normal;
            this.Button_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Update.FlatAppearance.BorderSize = 0;
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Update.ForeColor = System.Drawing.Color.Black;
            this.Button_Update.Location = new System.Drawing.Point(27, 160);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(166, 76);
            this.Button_Update.TabIndex = 25;
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Visible = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            this.Button_Update.MouseLeave += new System.EventHandler(this.Button_Update_MouseLeave);
            this.Button_Update.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_Update_MouseMove);
            // 
            // Verif
            // 
            this.Verif.BackColor = System.Drawing.Color.Transparent;
            this.Verif.BackgroundImage = global::PBLauncher.Properties.Resources.Check_Normal;
            this.Verif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Verif.FlatAppearance.BorderSize = 0;
            this.Verif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Verif.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Verif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.Verif.Location = new System.Drawing.Point(100, 160);
            this.Verif.Margin = new System.Windows.Forms.Padding(2);
            this.Verif.Name = "Verif";
            this.Verif.Size = new System.Drawing.Size(106, 76);
            this.Verif.TabIndex = 26;
            this.Verif.UseVisualStyleBackColor = false;
            this.Verif.Visible = false;
            this.Verif.Click += new System.EventHandler(this.Verif_Click);
            this.Verif.MouseLeave += new System.EventHandler(this.Verif_MouseLeave);
            this.Verif.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Verif_MouseMove);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.BackgroundImage = global::PBLauncher.Properties.Resources.Closed_Normal1;
            this.Fechar.Location = new System.Drawing.Point(884, 2);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(24, 24);
            this.Fechar.TabIndex = 27;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            this.Fechar.MouseLeave += new System.EventHandler(this.Fechar_MouseLeave);
            this.Fechar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Fechar_MouseMove);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::PBLauncher.Properties.Resources.Hide_Normal;
            this.Minimize.Location = new System.Drawing.Point(856, 2);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 24);
            this.Minimize.TabIndex = 28;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            this.Minimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseMove);
            // 
            // timerDownload
            // 
            this.timerDownload.Tick += new System.EventHandler(this.timerDownload_Tick_1);
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(12, 36);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(100, 20);
            this.textBoxSavePath.TabIndex = 31;
            this.textBoxSavePath.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Powered by XENON Protect.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Silver;
            this.progressBar2.BorderRadius = 3;
            this.progressBar2.Location = new System.Drawing.Point(12, 49);
            this.progressBar2.MaximumValue = 100;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBar2.Size = new System.Drawing.Size(536, 10);
            this.progressBar2.TabIndex = 36;
            this.progressBar2.Value = 100;
            // 
            // Jogar
            // 
            this.Jogar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Jogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Jogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Jogar.BorderRadius = 4;
            this.Jogar.ButtonText = "JOGAR";
            this.Jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jogar.DisabledColor = System.Drawing.Color.Gray;
            this.Jogar.Iconcolor = System.Drawing.Color.Transparent;
            this.Jogar.Iconimage = null;
            this.Jogar.Iconimage_right = null;
            this.Jogar.Iconimage_right_Selected = null;
            this.Jogar.Iconimage_Selected = null;
            this.Jogar.IconMarginLeft = 0;
            this.Jogar.IconMarginRight = 0;
            this.Jogar.IconRightVisible = true;
            this.Jogar.IconRightZoom = 0D;
            this.Jogar.IconVisible = true;
            this.Jogar.IconZoom = 90D;
            this.Jogar.IsTab = false;
            this.Jogar.Location = new System.Drawing.Point(733, 20);
            this.Jogar.Name = "Jogar";
            this.Jogar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Jogar.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.Jogar.OnHoverTextColor = System.Drawing.Color.White;
            this.Jogar.selected = false;
            this.Jogar.Size = new System.Drawing.Size(166, 39);
            this.Jogar.TabIndex = 37;
            this.Jogar.Text = "JOGAR";
            this.Jogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Jogar.Textcolor = System.Drawing.Color.White;
            this.Jogar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jogar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Veri
            // 
            this.Veri.Activecolor = System.Drawing.Color.MediumBlue;
            this.Veri.BackColor = System.Drawing.Color.MediumBlue;
            this.Veri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Veri.BorderRadius = 4;
            this.Veri.ButtonText = "VERIF.";
            this.Veri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Veri.DisabledColor = System.Drawing.Color.Gray;
            this.Veri.Iconcolor = System.Drawing.Color.Transparent;
            this.Veri.Iconimage = null;
            this.Veri.Iconimage_right = null;
            this.Veri.Iconimage_right_Selected = null;
            this.Veri.Iconimage_Selected = null;
            this.Veri.IconMarginLeft = 0;
            this.Veri.IconMarginRight = 0;
            this.Veri.IconRightVisible = true;
            this.Veri.IconRightZoom = 0D;
            this.Veri.IconVisible = true;
            this.Veri.IconZoom = 90D;
            this.Veri.IsTab = false;
            this.Veri.Location = new System.Drawing.Point(621, 20);
            this.Veri.Name = "Veri";
            this.Veri.Normalcolor = System.Drawing.Color.MediumBlue;
            this.Veri.OnHovercolor = System.Drawing.Color.Blue;
            this.Veri.OnHoverTextColor = System.Drawing.Color.White;
            this.Veri.selected = false;
            this.Veri.Size = new System.Drawing.Size(106, 39);
            this.Veri.TabIndex = 38;
            this.Veri.Text = "VERIF.";
            this.Veri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Veri.Textcolor = System.Drawing.Color.White;
            this.Veri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Veri.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.total_label);
            this.panel1.Controls.Add(this.Veri);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.Jogar);
            this.panel1.Controls.Add(this.lblstatus);
            this.panel1.Controls.Add(this.fileName);
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 74);
            this.panel1.TabIndex = 39;
            // 
            // total_label
            // 
            this.total_label.BackColor = System.Drawing.Color.Transparent;
            this.total_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.total_label.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.total_label.ForeColor = System.Drawing.Color.White;
            this.total_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.total_label.Location = new System.Drawing.Point(5, 26);
            this.total_label.Name = "total_label";
            this.total_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.total_label.Size = new System.Drawing.Size(543, 21);
            this.total_label.TabIndex = 41;
            this.total_label.Text = "0,00/0,00";
            this.total_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 138);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(888, 361);
            this.webBrowser1.TabIndex = 40;
            this.webBrowser1.Url = new System.Uri("https://azurepb.net/pblauncher/WebLauncher/", System.UriKind.Absolute);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PBLauncher.Properties.Resources.Logo_topo;
            this.pictureBox1.Location = new System.Drawing.Point(228, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Fechar);
            this.panel2.Controls.Add(this.Minimize);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 30);
            this.panel2.TabIndex = 42;
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.Firebrick;
            this.Sair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sair.Controls.Add(this.bunifuFlatButton2);
            this.Sair.Controls.Add(this.bunifuFlatButton1);
            this.Sair.Controls.Add(this.label_launcher);
            this.Sair.Location = new System.Drawing.Point(0, 210);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(912, 174);
            this.Sair.TabIndex = 43;
            this.Sair.Paint += new System.Windows.Forms.PaintEventHandler(this.Sair_Paint);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 4;
            this.bunifuFlatButton2.ButtonText = "Não";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(459, 123);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(166, 39);
            this.bunifuFlatButton2.TabIndex = 40;
            this.bunifuFlatButton2.Text = "Não";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 4;
            this.bunifuFlatButton1.ButtonText = "Sim";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(287, 123);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(166, 39);
            this.bunifuFlatButton1.TabIndex = 39;
            this.bunifuFlatButton1.Text = "Sim";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // label_launcher
            // 
            this.label_launcher.BackColor = System.Drawing.Color.Transparent;
            this.label_launcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_launcher.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_launcher.ForeColor = System.Drawing.Color.Black;
            this.label_launcher.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_launcher.Location = new System.Drawing.Point(267, 36);
            this.label_launcher.Name = "label_launcher";
            this.label_launcher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_launcher.Size = new System.Drawing.Size(377, 27);
            this.label_launcher.TabIndex = 1;
            this.label_launcher.Text = "Você realmente deseja sair do launcher ?";
            this.label_launcher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AttDetect
            // 
            this.AttDetect.BackColor = System.Drawing.Color.Green;
            this.AttDetect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttDetect.Controls.Add(this.bunifuFlatButton3);
            this.AttDetect.Controls.Add(this.bunifuFlatButton4);
            this.AttDetect.Controls.Add(this.label2);
            this.AttDetect.Location = new System.Drawing.Point(0, 210);
            this.AttDetect.Name = "AttDetect";
            this.AttDetect.Size = new System.Drawing.Size(912, 174);
            this.AttDetect.TabIndex = 44;
            this.AttDetect.Visible = false;
            this.AttDetect.Paint += new System.Windows.Forms.PaintEventHandler(this.AttDetect_Paint);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 4;
            this.bunifuFlatButton3.ButtonText = "Não";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(459, 123);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(166, 39);
            this.bunifuFlatButton3.TabIndex = 40;
            this.bunifuFlatButton3.Text = "Não";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 4;
            this.bunifuFlatButton4.ButtonText = "Sim";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(287, 123);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(166, 39);
            this.bunifuFlatButton4.TabIndex = 39;
            this.bunifuFlatButton4.Text = "Sim";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(278, 20);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(358, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uma nova atualização está disponível\r\nDeseja atualizar agora ?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Ptoken
            // 
            this.Ptoken.Location = new System.Drawing.Point(12, 88);
            this.Ptoken.Name = "Ptoken";
            this.Ptoken.Size = new System.Drawing.Size(100, 20);
            this.Ptoken.TabIndex = 45;
            // 
            // PBLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 595);
            this.Controls.Add(this.Ptoken);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.AttDetect);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.Verif);
            this.Controls.Add(this.TotalBar);
            this.Controls.Add(this.ArchiveBar);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PBLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBLauncher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Sair.ResumeLayout(false);
            this.AttDetect.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ArchiveBar;
        private System.Windows.Forms.PictureBox TotalBar;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Verif;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Timer timerDownload;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuProgressBar progressBar2;
        private Bunifu.Framework.UI.BunifuFlatButton Jogar;
        private Bunifu.Framework.UI.BunifuFlatButton Veri;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Sair;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label_launcher;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Panel AttDetect;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ptoken;
    }
}

