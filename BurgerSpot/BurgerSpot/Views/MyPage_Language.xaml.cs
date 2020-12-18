using System;
using System.Collections.Generic;
using BurgerSpot.Model;
using Xamarin.Forms;

namespace BurgerSpot.Views
{
    public partial class MyPage_Language : ContentPage
    {
        public MyPage_Language()
        {
            InitializeComponent();
            imarabe.Source = ImageSource.FromFile("morocco.png");
            imfrance.Source = ImageSource.FromFile("france.png");

            var n1 = new TapGestureRecognizer();
            n1.Tapped += async (s, e) =>
            {
                constants.arabe = 1;
                constants.france = 0;
                Navigation.PushModalAsync(new Logins());

            };
            imarabe.GestureRecognizers.Add(n1);

            var n2 = new TapGestureRecognizer();
            n2.Tapped += async (s, e) =>
            {
                constants.arabe = 0;
                constants.france = 1;
                Navigation.PushModalAsync(new Logins());
            };
            imfrance.GestureRecognizers.Add(n2);
        }

    }
}
