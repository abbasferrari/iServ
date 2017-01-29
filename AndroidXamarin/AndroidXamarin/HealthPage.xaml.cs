using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Rg.Plugins.Popup;
using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class HealthPage : ContentPage
    {
        public HealthPage()
        {
            InitializeComponent();
        }
        private async void OnOpenPopupA(object sender, EventArgs e)
        {
            var page = new Queue();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupB(object sender, EventArgs e)
        {
            var page = new ZikaOrDengue();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupC(object sender, EventArgs e)
        {
            var page = new LackOfMaterials();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupD(object sender, EventArgs e)
        {
            var page = new YouAttended();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupE(object sender, EventArgs e)
        {
            var page = new HealthSuggestions();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupF(object sender, EventArgs e)
        {
            var page = new HealthExpress();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
    }
}
