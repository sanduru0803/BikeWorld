using BikeWorld.ViewModels;
using BikeWorld.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BikeWorld
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage),typeof(MainPage));

        }

    }
}
