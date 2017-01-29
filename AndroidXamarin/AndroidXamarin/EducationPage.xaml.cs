using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class EducationPage : ContentPage
    {
        public EducationPage()
        {
            InitializeComponent();

        }
        private async void OnOpenPopupA(object sender, EventArgs e)
        {
            var page = new QualityMeals();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupB(object sender, EventArgs e)
        {
            var page = new LackOfStaff();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupC(object sender, EventArgs e)
        {
            var page = new CollegeViolence();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupD(object sender, EventArgs e)
        {
            var page = new ImproveYourSchool();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupE(object sender, EventArgs e)
        {
            var page = new Bullying();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupF(object sender, EventArgs e)
        {
            var page = new EducationSuggestions();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }
        private async void OnOpenPopupG(object sender, EventArgs e)
        {
            var page = new EducationExpress();

            // await Navigation.PushPopupAsync(page);
            // or
            await PopupNavigation.PushAsync(page);
        }

    }
}
