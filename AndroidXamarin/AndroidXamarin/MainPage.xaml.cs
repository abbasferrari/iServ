using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
namespace AndroidXamarin
{

    
    public partial class MainPage : ContentPage
    {
         
        public MainPage()
        {
            
            InitializeComponent();
            var tapGestureRecognizer_forgotpassword= new TapGestureRecognizer();
            tapGestureRecognizer_forgotpassword.Tapped += (s, e) => {
               // var Page = new ForgetPassword();
                Navigation.PushAsync(new ForgetPassword());
            };

           forgotPassword.GestureRecognizers.Add(tapGestureRecognizer_forgotpassword);
            var tapGestureRecognizer_signup= new TapGestureRecognizer();
            tapGestureRecognizer_signup.Tapped += (s, e) => {
                Navigation.PushAsync(new SignUpCS());
            };
            signUp.GestureRecognizers.Add(tapGestureRecognizer_signup);
            /* var tapGestureRecognizer = new TapGestureRecognizer();
             tapGestureRecognizer.Tapped += (s, e) => {
                 // handle the tap
             };
             tapGestureRecognizer.NumberOfTapsRequired = 1;
             forgotPassword.GestureRecognizers.Add(tapGestureRecognizer);

     */

        }
        void onLogin(object sender, EventArgs e)
        {
           Navigation.PushAsync(new TabbedBarPage());
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args) {
            Navigation.PushAsync(new ForgetPassword());
        }
        private async void OnOpenPupup(object sender, EventArgs e)
        {
            var page = new PopUpPage();

            await Navigation.PushAsync(page);
            // or
            // PopupNavigation.PushAsync(page);
        }

    }

}
