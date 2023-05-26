using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleCylinderPage : ContentPage
    {
        public SingleCylinderPage()
        {
            InitializeComponent();
        }

        private void RTR200_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ApacheRTR200_4vPage());
        }
        private void NS200_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PulsarNS200Page());
        }
    }
}