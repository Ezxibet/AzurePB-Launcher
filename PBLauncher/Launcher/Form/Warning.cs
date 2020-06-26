using Launcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }
        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Sair_MouseMove(object sender, MouseEventArgs e)
        {
            Sair.BackgroundImage = Resources.Back_Over;
            Sair.BackColor = Color.Black;
        }
        private void Sair_MouseLeave(object sender, EventArgs e)
        {
            Sair.BackgroundImage = Resources.Back_Normal;
            Sair.BackColor = Color.Black;
        }
        private void Warning_Load(object sender, EventArgs e)
        {
            label1.Text = "Você foi banido por desrespeitar as regras do jogo.";
        }
    }
}
