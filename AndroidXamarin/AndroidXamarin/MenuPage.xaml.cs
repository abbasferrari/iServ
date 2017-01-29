using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
           
           // var beachImage = new Image { Aspect = Aspect.AspectFit };
          //  beachImage.Source = ImageSource.FromFile("EMUDE.jpg");

            //var tapImage = new TapGestureRecognizer();
            //Binding events  
            //tapImage.Tapped += tapImage_Tapped;
            //Associating tap events to the image buttons  
            //img.GestureRecognizers.Add(tapImage);

            var tapGestureRecognizer_health = new TapGestureRecognizer();
            tapGestureRecognizer_health.Tapped += (s, e) => {
                Navigation.PushAsync(new TabbedPageThree());
            };
            var tapGestureRecognizer_saftey= new TapGestureRecognizer();
            tapGestureRecognizer_saftey.Tapped += (s, e) => {
                Navigation.PushAsync(new TabbedPageTwo());
            };
            var tapGestureRecognizer_transport = new TapGestureRecognizer();
            tapGestureRecognizer_transport.Tapped += (s, e) => {
                Navigation.PushAsync(new TabbedPageFour());
            };
            var tapGestureRecognizer_education = new TapGestureRecognizer();
            tapGestureRecognizer_education.Tapped += (s, e) => {
                Navigation.PushAsync(new TabbedPageFive());
            };
            img1.GestureRecognizers.Add(tapGestureRecognizer_saftey);
            img2.GestureRecognizers.Add(tapGestureRecognizer_health);
            img3.GestureRecognizers.Add(tapGestureRecognizer_transport);
            img4.GestureRecognizers.Add(tapGestureRecognizer_education);
        }
    }
}
