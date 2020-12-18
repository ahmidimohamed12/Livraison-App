using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BurgerSpot.Views
{
    public partial class MyPage_btntest : ContentPage
    {
        public MyPage_btntest()
        {
            InitializeComponent();
            btnb.Clicked += async (s, e) =>
            {
                await DisplayAlert("kdkkd","djdjjd","jdndd");
            };
           
        }
    }
}
