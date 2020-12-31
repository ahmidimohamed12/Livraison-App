using System;
using System.Collections.Generic;
using BurgerSpot.Model;
using BurgerSpot.ViewModel;
using Newtonsoft.Json;
using System.Net.Http;
using Xamarin.Forms;
using System.Linq;
using System.Net.Http.Headers;

namespace BurgerSpot.Views
{
    public partial class MyPage_listshopbindigs : ContentPage
    {
        
        public MyPage_listshopbindigs()
        {
            InitializeComponent();

            ls.SelectionChanged += pl;

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://mrsool.1337center.de/api/produits1");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("http://mrsool.1337center.de/api/produits1").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            //database
            List<Produits> ss = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Produits>>(result);
            ls.ItemsSource = ss.ToList();



          //  lst.ItemsSource = ss.ToList();
            //lst.ItemsSource = ss.ToList();

            //your code here;
            //   RemplireData rm = new RemplireData();
            //   var ls =  await rm.getallcategories();
            //  lst.ItemsSource = ls.ToList();
        }

        private void pl(object sender,EventArgs e)
        {
            DisplayAlert("jddjdwiw", "siwiws", "sxndnd");
        }
        public static Produits pr;
        async void   collectionList_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var produit = (CollectionView)e.CurrentSelection;

            pr =(Produits) produit.ItemsSource;

            await Navigation.PushModalAsync(new MyPage_produit_once());
        }

       
    }
}
