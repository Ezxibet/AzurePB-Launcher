using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public class Utils
    {
        public static DialogResult InfoBowShow(string text)
        {
            return MessageBox.Show(text, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
