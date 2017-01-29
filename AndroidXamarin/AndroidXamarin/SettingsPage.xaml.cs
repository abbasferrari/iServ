using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
           /* var tapGestureRecognizer_imageid = new TapGestureRecognizer();
            tapGestureRecognizer_imageid.Tapped += (s, e) =>
            {
                var page = new PopUpPage();
                // PopupNavigation.PushAsync(page);
                Navigation.PushAsync(page);
            };
            accountid.GestureRecognizers.Add(tapGestureRecognizer_imageid);
            accountsettings.GestureRecognizers.Add(tapGestureRecognizer_imageid);
        */}
        private async void OnOpenPopup(object sender, EventArgs e)
        {
            var page = new PopUpPage();
            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }

    }
}
