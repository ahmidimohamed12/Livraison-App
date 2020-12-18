using System;
using System.Collections.Generic;
using BurgerSpot.ViewModel;
using BurgerSpot.Model;
using BurgerSpot.Views;
using Xamarin.Forms;

namespace BurgerSpot.Views
{
    public partial class MyPage_start : ContentPage
    {
        public MyPage_start()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(4),  () =>
            {
                int n = function_Repete.connection_status();
                if (n == 1)
                    Navigation.PushModalAsync(new MyPage_Language());
                else
                    Navigation.PushModalAsync(new MyPage_pasconnection());
                return false;
            });
        }
      
    }
}
