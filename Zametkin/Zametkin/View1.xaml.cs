using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zametkin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View1 : ContentView
    {
        public View1()
        {
            InitializeComponent();
            
        }
        private async void returnOnMain(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ListViewPage1());
        }
        private async void safeRecord(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ListViewPage1());
        }
    }
}