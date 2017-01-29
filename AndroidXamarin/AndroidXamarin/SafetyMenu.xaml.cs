using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup;
namespace AndroidXamarin
{
    public partial class SafetyMenu : ContentPage
    {
        public SafetyMenu()
        {
            InitializeComponent();
           /* var tapGestureRecognizer_button1 = new TapGestureRecognizer();
            tapGestureRecognizer_button1.Tapped += (s, e) => {
                Navigation.PushAsync(new MapPage());
            };
            seekbarbutton.GestureRecognizers.Add(tapGestureRecognizer_button1);
            */
        }
        private async void OnOpenPopupA(object sender, EventArgs e)
        {
            var page = new AssaultTheft();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupB(object sender, EventArgs e)
        {
            var page = new UsersOrDrugSales();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupC(object sender, EventArgs e)
        {
            var page = new FireFight();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupD(object sender, EventArgs e)
        {
            var page = new SafeSuggestions();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupE(object sender, EventArgs e)
        {
            var page = new SafeSeekbar();
            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
    }
}
