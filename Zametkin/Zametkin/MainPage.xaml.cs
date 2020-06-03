using Newtonsoft.Json;
using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Zametkin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Zametkin";
            //FirebaseClient firebase = new FirebaseClient("https://zametkin-2c155.firebaseio.com/");

        }
        private async void LogIn(object sender, EventArgs e)
        {
            /*string login = loginK.Text;
            string password = passwordK.Text;
            
            HttpClient http = new HttpClient();
            var uri = new Uri("https://192.168.0.102:52159/UserService.svc/users/admin");
            var response = await http.GetStringAsync(uri);
            string s = (string)response;*/
           //if (s.Equals(password))
           //{
                await Navigation.PushModalAsync(new NavigationPage(new ListViewPage1()));
           // }

            

        }
    }

}
