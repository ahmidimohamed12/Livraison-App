﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BurgerSpot.Views
{
    public partial class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage()
        {
            InitializeComponent();
        }
        public CustomNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}
