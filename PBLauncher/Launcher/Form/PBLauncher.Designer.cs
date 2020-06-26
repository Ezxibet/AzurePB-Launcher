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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PBLauncher));
            this.TotalBar = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Arquivo = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Update_Worker = new System.ComponentModel.BackgroundWorker();
            this.Verif = new System.Windows.Forms.Label();
            this.ArchiveBar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LoginPainel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblogin = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbl_usuário = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TotalBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.LoginPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalBar
            // 
            this.TotalBar.BackColor = System.Drawing.Color.Transparent;
            this.TotalBar.BackgroundImage = global::Launcher.Properties.Resources.TotalBar;
            this.TotalBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TotalBar.Location = new System.Drawing.Point(42, 563);
            this.TotalBar.Name = "TotalBar";
            this.TotalBar.Size = new System.Drawing.Size(634, 9);
            this.TotalBar.TabIndex = 1;
            this.TotalBar.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Black;
            this.Start.BackgroundImage = global::Launcher.Properties.Resources.Iniciar_Normal;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(691, 449);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(184, 76);
            this.Start.TabIndex = 8;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseEnter += new System.EventHandler(this.Start_MouseEnter);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Font = new System.Drawing.Font("Arial", 9F);
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(49, 441);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(64, 15);
            this.Status.TabIndex = 19;
            this.Status.Text = "Non string";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.Font = new System.Drawing.Font("Arial", 9F);
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(49, 508);
            this.Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(33, 15);
            this.Total.TabIndex = 21;
            this.Total.Text = "Total";
            // 
            // Arquivo
            // 
            this.Arquivo.AutoSize = true;
            this.Arquivo.BackColor = System.Drawing.Color.Transparent;
            this.Arquivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arquivo.ForeColor = System.Drawing.Color.White;
            this.Arquivo.Location = new System.Drawing.Point(49, 480);
            this.Arquivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(27, 15);
            this.Arquivo.TabIndex = 20;
            this.Arquivo.Text = "File";
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.BackColor = System.Drawing.Color.Transparent;
            this.fileName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.fileName.ForeColor = System.Drawing.Color.White;
            this.fileName.Location = new System.Drawing.Point(89, 464);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(20, 16);
            this.fileName.TabIndex = 23;
            this.fileName.Text = "   ";
            this.fileName.Visible = false;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.BackColor = System.Drawing.Color.Transparent;
            this.total_label.Font = new System.Drawing.Font("Arial", 9.75F);
            this.total_label.ForeColor = System.Drawing.Color.White;
            this.total_label.Location = new System.Drawing.Point(608, 477);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(62, 16);
            this.total_label.TabIndex = 24;
            this.total_label.Text = "0.00/0.00";
            this.total_label.Visible = false;
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.Black;
            this.Button_Update.BackgroundImage = global::Launcher.Properties.Resources.Atualizar_Normal1;
            this.Button_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Update.FlatAppearance.BorderSize = 0;
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Update.ForeColor = System.Drawing.Color.Black;
            this.Button_Update.Location = new System.Drawing.Point(691, 449);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(184, 76);
            this.Button_Update.TabIndex = 25;
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            this.Button_Update.MouseEnter += new System.EventHandler(this.Button_Update_MouseEnter);
            this.Button_Update.MouseLeave += new System.EventHandler(this.Button_Update_MouseLeave);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.BackgroundImage = global::Launcher.Properties.Resources.Fechar_Normal;
            this.Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fechar.Location = new System.Drawing.Point(893, 5);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(24, 24);
            this.Fechar.TabIndex = 27;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::Launcher.Properties.Resources.minimize;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize.Location = new System.Drawing.Point(863, 5);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 24);
            this.Minimize.TabIndex = 28;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Verif
            // 
            this.Verif.AutoSize = true;
            this.Verif.BackColor = System.Drawing.Color.Transparent;
            this.Verif.Font = new System.Drawing.Font("Arial", 9F);
            this.Verif.ForeColor = System.Drawing.Color.White;
            this.Verif.Location = new System.Drawing.Point(802, 530);
            this.Verif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Verif.Name = "Verif";
            this.Verif.Size = new System.Drawing.Size(52, 15);
            this.Verif.TabIndex = 29;
            this.Verif.Text = "Reparar";
            this.Verif.MouseEnter += new System.EventHandler(this.Verif_MouseEnter);
            this.Verif.MouseLeave += new System.EventHandler(this.Verif_MouseLeave);
            // 
            // ArchiveBar
            // 
            this.ArchiveBar.BackColor = System.Drawing.Color.Transparent;
            this.ArchiveBar.BackgroundImage = global::Launcher.Properties.Resources.ArchiveBar;
            this.ArchiveBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ArchiveBar.Location = new System.Drawing.Point(50, 496);
            this.ArchiveBar.Name = "ArchiveBar";
            this.ArchiveBar.Size = new System.Drawing.Size(625, 9);
            this.ArchiveBar.TabIndex = 0;
            this.ArchiveBar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(923, 403);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Launcher.Properties.Resources.ArchiveBar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(50, 522);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(625, 9);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // LoginPainel
            // 
            this.LoginPainel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPainel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPainel.BackgroundImage")));
            this.LoginPainel.Controls.Add(this.label3);
            this.LoginPainel.Controls.Add(this.label2);
            this.LoginPainel.Controls.Add(this.lblogin);
            this.LoginPainel.Controls.Add(this.checkBox1);
            this.LoginPainel.Controls.Add(this.lbl_usuário);
            this.LoginPainel.Controls.Add(this.Login_Button);
            this.LoginPainel.Controls.Add(this.PasswordBox);
            this.LoginPainel.Controls.Add(this.lbl_senha);
            this.LoginPainel.Controls.Add(this.LoginBox);
            this.LoginPainel.Location = new System.Drawing.Point(26, 331);
            this.LoginPainel.Name = "LoginPainel";
            this.LoginPainel.Size = new System.Drawing.Size(921, 125);
            this.LoginPainel.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(804, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Cadastre-se";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(682, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Não tem uma conta?";
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.BackColor = System.Drawing.Color.Transparent;
            this.lblogin.Font = new System.Drawing.Font("Arial", 9F);
            this.lblogin.ForeColor = System.Drawing.Color.White;
            this.lblogin.Location = new System.Drawing.Point(43, 5);
            this.lblogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(64, 15);
            this.lblogin.TabIndex = 47;
            this.lblogin.Text = "Non string";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(44, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 46;
            this.checkBox1.Text = "Lembrar login";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lbl_usuário
            // 
            this.lbl_usuário.AutoSize = true;
            this.lbl_usuário.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuário.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_usuário.ForeColor = System.Drawing.Color.White;
            this.lbl_usuário.Location = new System.Drawing.Point(43, 38);
            this.lbl_usuário.Name = "lbl_usuário";
            this.lbl_usuário.Size = new System.Drawing.Size(54, 15);
            this.lbl_usuário.TabIndex = 44;
            this.lbl_usuário.Text = "Usuário:";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.Brown;
            this.Login_Button.BackgroundImage = global::Launcher.Properties.Resources.Login_Normal;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Login_Button.Location = new System.Drawing.Point(671, 38);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(208, 47);
            this.Login_Button.TabIndex = 43;
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            this.Login_Button.MouseEnter += new System.EventHandler(this.Login_Button_MouseEnter);
            this.Login_Button.MouseLeave += new System.EventHandler(this.Login_Button_MouseLeave);
            this.Login_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_Button_MouseMove);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.Black;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Font = new System.Drawing.Font("Arial", 9F);
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.Location = new System.Drawing.Point(363, 56);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(299, 27);
            this.PasswordBox.TabIndex = 42;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_senha.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_senha.ForeColor = System.Drawing.Color.White;
            this.lbl_senha.Location = new System.Drawing.Point(361, 38);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(46, 15);
            this.lbl_senha.TabIndex = 45;
            this.lbl_senha.Text = "Senha:";
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.Black;
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginBox.Font = new System.Drawing.Font("Arial", 9F);
            this.LoginBox.ForeColor = System.Drawing.Color.White;
            this.LoginBox.Location = new System.Drawing.Point(44, 56);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(299, 27);
            this.LoginBox.TabIndex = 41;
            // 
            // PBLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.BG_Kyo_1;
            this.ClientSize = new System.Drawing.Size(921, 562);
            this.Controls.Add(this.LoginPainel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Verif);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.TotalBar);
            this.Controls.Add(this.ArchiveBar);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.Arquivo);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Button_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PBLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBLauncher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.TotalBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.LoginPainel.ResumeLayout(false);
            this.LoginPainel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TotalBar;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Arquivo;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox Minimize;
        private System.ComponentModel.BackgroundWorker Update_Worker;
        private System.Windows.Forms.Label Verif;
        private System.Windows.Forms.PictureBox ArchiveBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbl_usuário;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox LoginBox;
        public System.Windows.Forms.Panel LoginPainel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

