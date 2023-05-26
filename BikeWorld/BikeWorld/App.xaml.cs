using BikeWorld.Services;
using BikeWorld.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeWorld
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }
    }
}
