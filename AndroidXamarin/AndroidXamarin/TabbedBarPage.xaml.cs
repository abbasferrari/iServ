using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class TabbedBarPage : TabbedPage
    {
        public TabbedBarPage()
        {
            InitializeComponent();
      

          
            

        Children.Add(new SignUpCS());
            Children.Add(new MapPage());
            Children.Add(new MenuPage());
            //Children.Add(new MenuPage());
            Children.Add(new SettingsPage());
            
        }
     
    }
}
