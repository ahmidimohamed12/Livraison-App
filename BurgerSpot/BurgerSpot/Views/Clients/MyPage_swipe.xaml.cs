using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BurgerSpot.Views.Clients
{
    public partial class MyPage_swipe : ContentPage
    {
        public MyPage_swipe()
        {
            InitializeComponent();
            btn_next.Clicked += btn_click;
        }


        private async void btn_click(object sende,EventArgs e)
        {
            await Navigation.PushModalAsync(new btn_swip2());
        }
    }
}
  