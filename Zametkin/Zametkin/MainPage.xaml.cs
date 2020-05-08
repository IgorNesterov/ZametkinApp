using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            await Navigation.PushModalAsync(new NavigationPage(new ListViewPage1()));
        }
    }

}
