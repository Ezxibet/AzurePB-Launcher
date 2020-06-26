namespace Launcher
{
    partial class Conexao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conexao));
            this.Start = new System.ComponentModel.BackgroundWorker();
            this.label_launcher = new System.Windows.Forms.Label();
            this.LoadingOpacityUpdater = new System.Windows.Forms.Timer(this.components);
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
            this.label_launcher.Font = new System.Drawing.Font("Arial", 9F);
            this.label_launcher.ForeColor = System.Drawing.Color.White;
            this.label_launcher.Location = new System.Drawing.Point(254, 217);
            this.label_launcher.Name = "label_launcher";
            this.label_launcher.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_launcher.Size = new System.Drawing.Size(278, 13);
            this.label_launcher.TabIndex = 0;
            this.label_launcher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LoadingOpacityUpdater
            // 
            this.LoadingOpacityUpdater.Interval = 1;
            this.LoadingOpacityUpdater.Tick += new System.EventHandler(this.LoadingOpacityUpdater_Tick);
            // 
            // Conexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Launcher.Properties.Resources.BG_Connection;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 235);
            this.ControlBox = false;
            this.Controls.Add(this.label_launcher);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Conexao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Please_Wait_Load);
            this.Shown += new System.EventHandler(this.Conexao_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker Start;
        private System.Windows.Forms.Label label_launcher;
        private System.Windows.Forms.Timer LoadingOpacityUpdater;
    }
}