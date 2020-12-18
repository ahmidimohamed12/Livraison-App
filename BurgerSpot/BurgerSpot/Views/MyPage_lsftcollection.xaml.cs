using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Xamarin.Forms;
using System.Linq;
using BurgerSpot.Model;

namespace BurgerSpot.Views
{
    public partial class MyPage_lsftcollection : ContentPage
    {
        public MyPage_lsftcollection()
        {
            InitializeComponent();
          

        }
        protected override void OnAppearing()
        {
            // make a call to the base, that does nothing for now
            base.OnAppearing();
            HttpClient client = new HttpClient();
           // int k = int.Parse(uid);
            client.BaseAddress = new Uri("http://mrsoul.1337center.de/api/produits1");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("http://mrsoul.1337center.de/api/produits1").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            //database
            List<Produits> ss = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Produits>>(result);
            collectionList.ItemsSource = ss.ToList();
        }

    }
}
