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
    public partial class MultiCylinderPage : ContentPage
    {
        public MultiCylinderPage()
        {
            InitializeComponent();
        }

        private void H2R_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NinjaH2rPage());
        }

        private void ZX10R_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NinjaZx10r());
        }

        private void CBR1000RR_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new cbr1000rrPage());
        }

        private void PanigaleV4_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ducativ4rPage());
        }

        private void R1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new YamahaR1page());
        }

        private void Z900_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Z900page());
        }

        private void GSXR_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gsxr1000rPage());
        }
    }
}