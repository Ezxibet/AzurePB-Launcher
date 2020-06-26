using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.Serialization.Json;
using System.Windows.Navigation;
using System.Net.Http;
using System.Collections.ObjectModel;

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Interação lógica para UserControlHome.xam
    /// </summary>
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();
            DadaAll();
        }

        public class Acc
        {
            public string player_name { get; set; }
            public string exp { get; set; }
            public string rank { get; set; }
            public string kills_count { get; set; }
            public string deaths_count { get; set; }
            public string pos { get; set; }
        }

        protected async void DadaAll()
        {
            //await System.Threading.Tasks.Task.Delay(2000);
            
            try
            {
                HttpClient http = new HttpClient();
                HttpResponseMessage response = await http.GetAsync("https://badnesspb.ml/pblauncher/launcher/rank.php");
                response.EnsureSuccessStatusCode();
                
                string resultJSON = string.Empty;
                resultJSON = await response.Content.ReadAsStringAsync();

                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJSON));
                ObservableCollection<Acc> list = new ObservableCollection<Acc>();
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ObservableCollection<Acc>));
                list = (ObservableCollection<Acc>)serializer.ReadObject(ms);
                LV.ItemsSource = list;
            }catch
            {
                
            }

        }
    }
}
