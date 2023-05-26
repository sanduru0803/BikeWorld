using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YamahaR1page : ContentPage
    {
        public YamahaR1page()
        {
            InitializeComponent();
        }
        private void ButtonOthers(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = true;
        }
        private void ButtonBack(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }
        private async void OpenBrowser(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var url = button.ClassId;

            await Browser.OpenAsync(url);
        }
    }
}