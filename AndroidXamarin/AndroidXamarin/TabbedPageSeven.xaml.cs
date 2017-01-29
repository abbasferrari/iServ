﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AndroidXamarin
{
    public partial class TabbedPageSeven : TabbedPage
    {
        public TabbedPageSeven()
        {
            InitializeComponent();
            Children.Add(new SignUpCS());
            Children.Add(new MapPage());
            // Children.Add(new SafetyMenu());
            Children.Add(new SettingsPage());
        }
    }
}
