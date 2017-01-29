using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
namespace AndroidXamarin
{
    public partial class MapPage : ContentPage
    {
        Label label;
        public MapPage()
        {
            InitializeComponent();
            /* var map = new Map(
              MapSpan.FromCenterAndRadius(
                      new Position(37, -122), Distance.FromMiles(0.3)))
              {
                  IsShowingUser = true,
                  HeightRequest = 100,
                  WidthRequest = 960,
                  VerticalOptions = LayoutOptions.FillAndExpand
              };
              var stack = new StackLayout { Spacing = 0 };
              stack.Children.Add(map);
              Content = stack;*/
            Label header = new Label
            {
                Text = "Slider",
                Font = Font.BoldSystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            Slider slider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            slider.ValueChanged += OnSliderValueChanged;

            label = new Label
            {
                Text = "Slider value is 0",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    slider,
                    label
                }
            };
            
    }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Slider value is {0:F1}", e.NewValue);

        }
    }
}
