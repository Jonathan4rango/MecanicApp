using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MecanicApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new NavigationPage(new LoginGrid());
            MainPage = new LoginGrid();
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
