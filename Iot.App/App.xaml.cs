using Iot.App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Iot.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage()
            {
                BarBackgroundColor = Color.FromHex("#0d1431"),
                BackgroundColor = Color.FromHex("#131e54"),

            };


            //MainPage = new PersonPage();
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
