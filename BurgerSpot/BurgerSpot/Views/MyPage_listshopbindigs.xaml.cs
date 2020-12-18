using System;
using System.Collections.Generic;
using BurgerSpot.Model;
using BurgerSpot.ViewModel;
using Xamarin.Forms;
using System.Linq;
namespace BurgerSpot.Views
{
    public partial class MyPage_listshopbindigs : ContentPage
    {
        public MyPage_listshopbindigs()
        {
            InitializeComponent();
            
           
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //your code here;
         //   RemplireData rm = new RemplireData();
         //   var ls =  await rm.getallcategories();
          //  lst.ItemsSource = ls.ToList();
        }
      
    }
}
