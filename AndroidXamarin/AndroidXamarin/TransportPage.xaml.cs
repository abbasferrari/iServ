using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class TransportPage : ContentPage
    {
        public TransportPage()
        {
            InitializeComponent();

            var tapGestureRecognizer_bus = new TapGestureRecognizer();
            tapGestureRecognizer_bus.Tapped += (s, e) => {
                Navigation.PushAsync(new BusPage());
            };
            var tapGestureRecognizer_boat = new TapGestureRecognizer();
            tapGestureRecognizer_boat.Tapped += (s, e) => {
                Navigation.PushAsync(new BoatPage());
            };
            var tapGestureRecognizer_subway = new TapGestureRecognizer();
            tapGestureRecognizer_subway.Tapped += (s, e) => {
                Navigation.PushAsync(new SubwayPage());
            };
            this.report1.GestureRecognizers.Add(tapGestureRecognizer_bus);
            this.report2.GestureRecognizers.Add(tapGestureRecognizer_boat);
            this.report3.GestureRecognizers.Add(tapGestureRecognizer_subway);
        }
        private async void OnOpenPopupA(object sender, EventArgs e)
        {
            var page = new TransportExpress();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
    }
}
