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
    public partial class EditRec : ContentPage
    {
        public EditRec()
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
        private async void delRec(object sender, EventArgs e)
        {
            var record = (Record)BindingContext;
            App.Database.DeleteItem(record.Id);
            //this.Navigation.PopAsync();
            await Navigation.PushModalAsync(new NavigationPage(new ListViewPage1()));
        }
        private async void getMaps(object sender, EventArgs e)
        {
            //var record = (Record)BindingContext;
            //App.Database.DeleteItem(record.Id);
            //this.Navigation.PopAsync();
            String s = coordinates.Text;
            await Navigation.PushModalAsync(new NavigationPage(new MapePage(s)));
        }
    }
}