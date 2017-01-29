using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class TabbedPageTwo : TabbedPage
    {
        public TabbedPageTwo()
        {
            InitializeComponent();
            /*TabbedPage tabs = new TabbedPage();

            tabs.Children.Add(
                new NavigationPage(new SafetyMenu() { Title = "Saftey" })
            );*/
            Children.Add(new SignUpCS());
            Children.Add(new MapPage());
          // Children.Add(new SafetyMenu());
            Children.Add(new SettingsPage());
         
           
        }
    }
}
