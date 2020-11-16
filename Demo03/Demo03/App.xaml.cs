using Demo03.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo03
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MonkeyPage());
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
