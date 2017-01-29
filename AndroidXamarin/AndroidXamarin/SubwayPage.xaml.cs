using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class SubwayPage : ContentPage
    {
        public SubwayPage()
        {
            InitializeComponent();
        }
        private async void OnOpenPopupA(object sender, EventArgs e)
        {
            var page = new Assault();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupB(object sender, EventArgs e)
        {
            var page = new SexualAbuse();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupC(object sender, EventArgs e)
        {
            var page = new Crowded();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupD(object sender, EventArgs e)
        {
            var page = new OverFlow();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupE(object sender, EventArgs e)
        {
            var page = new TransportExpress();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
    }
}
