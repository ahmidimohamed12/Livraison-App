using BurgerSpot.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BurgerSpot.Views.Clients;
using BurgerSpot.Model;
using FreshMvvm;
using BurgerSpot.ViewModel;

[assembly: ExportFont("BebasNeue.ttf", Alias = "ThemeFont")]
[assembly: ExportFont("Roboto.ttf", Alias = "LightFont")]
[assembly: ExportFont("Futura.ttf", Alias = "Futura")]


namespace BurgerSpot
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Shapes_Experimental", "MediaElement_Experimental" });
            MainPage = new MyPage_start(); //MyPage_pasconnection(); //DetailsPage();//BurgerSpot.Views.Clients.MyPage_swipe(); //PlantMallView();//MyPage_start(); //MyPage_registration(); //BurgerSpot.Views.Admin.categories.MyPage_addcateg(); //MyPage_start();//MyPage_menucategories();//MyPage_menucategories(); //MyPage_start();//MyPage_menucategories(); //MyPage_logins(); //MyPage_start();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
