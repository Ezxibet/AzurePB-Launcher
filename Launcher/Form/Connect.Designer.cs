namespace Launcher
{
    partial class Connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
            this.Start = new System.ComponentModel.BackgroundWorker();
            this.label_launcher = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Veri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Jogar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txxtSenha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Start_DoWork);
            this.Start.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Start_RunWorkerCompleted);
            // 
            // label_launcher
            // 
            this.label_launcher.BackColor = System.Drawing.Color.Transparent;
            this.label_launcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_launcher.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label_launcher.ForeColor = System.Drawing.Color.Black;
            this.label_launcher.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_launcher.Location = new System.Drawing.Point(432, 53);
            this.label_launcher.Name = "label_launcher";
            this.label_launcher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_launcher.Size = new System.Drawing.Size(237, 13);
            this.label_launcher.TabIndex = 0;
            this.label_launcher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_launcher.Visible = false;
            this.label_launcher.Click += new System.EventHandler(this.label_launcher_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 36;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(444, 414);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 37;
            this.textBox2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Fechar);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 30);
            this.panel1.TabIndex = 57;
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.BackgroundImage = global::PBLauncher.Properties.Resources.Closed_Normal1;
            this.Fechar.Location = new System.Drawing.Point(530, 2);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(24, 24);
            this.Fechar.TabIndex = 36;
            this.Fechar.TabStop = false;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::PBLauncher.Properties.Resources.Hide_Normal;
            this.Minimize.Location = new System.Drawing.Point(502, 2);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 24);
            this.Minimize.TabIndex = 37;
            this.Minimize.TabStop = false;
            // 
            // Veri
            // 
            this.Veri.Activecolor = System.Drawing.Color.MediumBlue;
            this.Veri.BackColor = System.Drawing.Color.MediumBlue;
            this.Veri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Veri.BorderRadius = 4;
            this.Veri.ButtonText = "CANCELAR";
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
            this.Veri.Location = new System.Drawing.Point(93, 325);
            this.Veri.Name = "Veri";
            this.Veri.Normalcolor = System.Drawing.Color.MediumBlue;
            this.Veri.OnHovercolor = System.Drawing.Color.Blue;
            this.Veri.OnHoverTextColor = System.Drawing.Color.White;
            this.Veri.selected = false;
            this.Veri.Size = new System.Drawing.Size(144, 39);
            this.Veri.TabIndex = 56;
            this.Veri.Text = "CANCELAR";
            this.Veri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Veri.Textcolor = System.Drawing.Color.White;
            this.Veri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Jogar
            // 
            this.Jogar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Jogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Jogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Jogar.BorderRadius = 4;
            this.Jogar.ButtonText = "LOGIN";
            this.Jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jogar.DisabledColor = System.Drawing.Color.Gray;
            this.Jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Jogar.Location = new System.Drawing.Point(319, 325);
            this.Jogar.Name = "Jogar";
            this.Jogar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Jogar.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.Jogar.OnHoverTextColor = System.Drawing.Color.White;
            this.Jogar.selected = false;
            this.Jogar.Size = new System.Drawing.Size(144, 39);
            this.Jogar.TabIndex = 55;
            this.Jogar.Text = "LOGIN";
            this.Jogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Jogar.Textcolor = System.Drawing.Color.White;
            this.Jogar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jogar.Click += new System.EventHandler(this.Jogar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Gray;
            this.txtSenha.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSenha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtSenha.BorderThickness = 3;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.isPassword = true;
            this.txtSenha.Location = new System.Drawing.Point(93, 274);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(370, 44);
            this.txtSenha.TabIndex = 54;
            this.txtSenha.Text = "SuaSenhaAqui";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Gray;
            this.txtUsuario.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtUsuario.BorderThickness = 3;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.isPassword = false;
            this.txtUsuario.Location = new System.Drawing.Point(93, 222);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(370, 44);
            this.txtUsuario.TabIndex = 53;
            this.txtUsuario.Text = "Seu ID";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-3, 144);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(667, 35);
            this.bunifuSeparator1.TabIndex = 52;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::PBLauncher.Properties.Resources.Logo_topo;
            this.pictureBox1.Location = new System.Drawing.Point(52, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Faça seu login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "www.azurepb.net";
            // 
            // txxtSenha
            // 
            this.txxtSenha.Location = new System.Drawing.Point(444, 400);
            this.txxtSenha.Name = "txxtSenha";
            this.txxtSenha.Size = new System.Drawing.Size(100, 20);
            this.txxtSenha.TabIndex = 59;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 446);
            this.ControlBox = false;
            this.Controls.Add(this.txxtSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Veri);
            this.Controls.Add(this.Jogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_launcher);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Please_Wait_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker Start;
        private System.Windows.Forms.Label label_launcher;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox Minimize;
        private Bunifu.Framework.UI.BunifuFlatButton Veri;
        private Bunifu.Framework.UI.BunifuFlatButton Jogar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txxtSenha;
    }
}