using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BurgerSpot.Views.Clients
{
    public partial class btn_swip2 : ContentPage
    {
        public btn_swip2()
        {
            InitializeComponent();
            btn_back.Clicked += btnback;
        }

        private async void btnback(object sender,EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
