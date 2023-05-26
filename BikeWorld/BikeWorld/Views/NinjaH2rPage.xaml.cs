using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace BikeWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NinjaH2rPage : ContentPage
    {
        //public System.Windows.Input.ICommand Myh2rTap => new Command<string>((url) =>
        //{
        //    Device.OpenUri(new System.Uri(url));
        //});
        public NinjaH2rPage()
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