namespace Launcher
{
    partial class Warning
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
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.BackgroundImage = global::Launcher.Properties.Resources.Fechar_Normal;
            this.Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fechar.Location = new System.Drawing.Point(297, 3);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(24, 24);
            this.Fechar.TabIndex = 28;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Sair
            // 
            this.Sair.BackgroundImage = global::Launcher.Properties.Resources.Back_Normal;
            this.Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sair.Cursor = System.Windows.Forms.Cursors.Default;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.ForeColor = System.Drawing.Color.Black;
            this.Sair.Location = new System.Drawing.Point(128, 99);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 29;
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            this.Sair.MouseLeave += new System.EventHandler(this.Sair_MouseLeave);
            this.Sair.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sair_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 15);
            this.label1.TabIndex = 30;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(325, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Fechar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Warning";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning";
            this.Load += new System.EventHandler(this.Warning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label1;
    }
}