using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zametkin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            Title = "Zametkin";
        }
        private async void safeRec(object sender, EventArgs e)
        {
            var record = (Record)BindingContext;
            if (!String.IsNullOrEmpty(record.Name))
            {
                App.Database.SaveItem(record);
            }
            //this.Navigation.PopAsync();
            await Navigation.PushModalAsync(new NavigationPage(new ListViewPage1()));
        } 
    }
}