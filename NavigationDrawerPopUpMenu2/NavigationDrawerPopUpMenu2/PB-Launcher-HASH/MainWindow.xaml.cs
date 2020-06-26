using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

namespace PB_Launcher_HASH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static string GetHash(string Name)
        {
            if (Name == string.Empty)
                return string.Empty;

            MD5 mD5 = MD5.Create();

            string Hash = string.Empty;

            FileStream fileStream = File.OpenRead(Name);
            Hash = BitConverter.ToString(mD5.ComputeHash(fileStream)).Replace("-", string.Empty);
            fileStream.Close();

            //MessageBox.Show(Hash);
            File.WriteAllText("hash.txt", Hash);
            System.Diagnostics.Process.Start("hash.txt");
            return Hash;
        }

        private void Get_Click(object sender, RoutedEventArgs e)
        {
            GetHash(Caminho.Text);
        }
    }
}
