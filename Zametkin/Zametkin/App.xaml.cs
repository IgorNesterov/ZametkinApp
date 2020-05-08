using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zametkin
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "records.db";
        public static RecordRepository database;
        public static RecordRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new RecordRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            if (Device.OS != TargetPlatform.WinPhone)
            {
                Resource.Culture = DependencyService.Get<ILocalize>()
                                    .GetCurrentCultureInfo();
            }

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
