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

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://mrsool.1337center.de/api/produits1");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("http://mrsool.1337center.de/api/produits1").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            //database
            List<Produits> ss = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Produits>>(result);

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
