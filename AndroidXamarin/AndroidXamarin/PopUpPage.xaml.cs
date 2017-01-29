using AndroidXamarin;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class PopUpPage : PopupPage
    {
        public PopUpPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        protected override bool OnBackButtonPressed()
        {
            // Prevent hide popup
            //return base.OnBackButtonPressed();
           return true;
        }
    }

    /*public PopUpPage()
    {
        DisplayAlert("alert Baby", "Do u Want to do?", "yes", "no");
        InitializeComponent();
        //this.OpenButton.Clicked += OpenButtonClicked;
    }
    private async void OnOpenPupup(object sender, EventArgs e)
    {
        var page = new MyPopupPage();

        await Navigation.PushPopupAsync(page);
        // or
        PopupNavigation.PushAsync(page);
    }*/
    /* void OpenButtonClicked(object sender, EventArgs e)
     {
         var popupLayout = this.Content as PopupLayout;

         if (popupLayout.IsPopupActive)
         {
             popupLayout.DismissPopup();
         }
         else
         {
             var list = new ListView()
             {
                 BackgroundColor = Color.White,
                 ItemsSource = new[] { "1", "2", "3" },
                 HeightRequest = this.Height * .5,
                 WidthRequest = this.Width * .8
             };

             list.ItemSelected += (s, args) =>
                 popupLayout.DismissPopup();

             popupLayout.ShowPopup(list);
         }
     }
   */
}

