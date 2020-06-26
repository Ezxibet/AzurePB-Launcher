using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Interação lógica para UserControlCreate.xam
    /// </summary>
    public partial class UserControlCreate : UserControl
    {
        public UserControlCreate()
        {
            InitializeComponent();
            Img();
        }

        private void Img()
        {
            BitmapImage img = new BitmapImage(new Uri("https://badnesspb.ml/pblauncher/launcher/web/images/img.jpg"));
            BitmapImage img1 = new BitmapImage(new Uri("https://badnesspb.ml/pblauncher/launcher/web/images/img1.jpg"));
            BitmapImage img2 = new BitmapImage(new Uri("https://badnesspb.ml/pblauncher/launcher/web/images/img2.jpg"));
            IMG_1.Source = img;
            IMG_2.Source = img1;
            IMG_3.Source = img2;
        }

    }
}
