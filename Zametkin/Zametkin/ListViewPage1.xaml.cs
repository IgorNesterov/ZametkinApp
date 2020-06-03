using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zametkin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage
    {
        //public ObservableCollection<string> Items { get; set; }

        public string[] Notes { get; set; }
        public IEnumerable<Record> NewNotes { get; set; }

        public ListViewPage1()
        {

            InitializeComponent();

            Title = "Zametkin";
            IEnumerable<Record> recs = App.Database.GetItems();

            NewNotes = App.Database.GetItems();
            base.OnAppearing();

            Record[] r = recs.ToArray();
            string[] str = new string[r.Length];
            for (int i = 0; i < r.Length; i = i + 1)
            {
                str[i] = r[i].Name;
            }
            Notes = str;//new string[] { "Заметка 0", "Заметка 1"};
            this.BindingContext = this;

        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Record selectedRecord = (Record)e.SelectedItem;
            EditRec edPage = new EditRec();
            edPage.BindingContext = selectedRecord;
            await Navigation.PushAsync(edPage);
        }

        private async void addRec(object sender, EventArgs e)
        {
            Record record = new Record();
            Page1 recordPage = new Page1();
            recordPage.BindingContext = record;

            await Navigation.PushModalAsync(new NavigationPage(recordPage));
        }
    }
}
