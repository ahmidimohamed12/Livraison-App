using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Xamarin.Forms;
using BurgerSpot.Model;
using BurgerSpot.ViewModel;
using Newtonsoft.Json;

namespace BurgerSpot.Views
{

    public partial class MyPage_registration : ContentPage
    {
          int np = 0;
        int nt = 0;
        public MyPage_registration()
        {
            InitializeComponent();


            if (constants.arabe == 1)
            {
                txtlo.Text = "تسجيل";
                txtlo.HorizontalOptions = LayoutOptions.Start; 
                txtemail.Placeholder = "البريد الإلكتروني";
                txtusername.Placeholder = "الإسم الكامل";
                txtpassword.Placeholder = "الرقم السري";
                txtaddress.Placeholder = "عنوان المنزل";
                txt.Placeholder = "رقم الهاتف";
            }
            if (constants.france == 1)
            {
                txtlo.Text = "S'inscrire";
                txtemail.Placeholder = "Email";
                txtusername.Placeholder = "Nom et Prenom";
                txtpassword.Placeholder = "mot de Pass";
                txtaddress.Placeholder = "Adress";
                txt.Placeholder = "Numero Telephone";
            }
          
            var n = new TapGestureRecognizer();

           

            


            n.Tapped += btn_click;

            gr.GestureRecognizers.Add(n);
        }

        private async void btn_click(object sender,EventArgs e)
        {
            if (txtemail.Text.Contains("@"))
            {
                if (txt.Text.Length >= 10)
                {
                    var cl = new Client()
                    {
                        adress = txtaddress.Text,
                        email = txtemail.Text,
                        id = 100 + DateTime.Now.Day + DateTime.Now.Second,
                        username = txtusername.Text,
                        passwords = txtpassword.Text,
                        telephone = txt.Text,
                    };


                    var httpClient = new HttpClient();
                    var Json = JsonConvert.SerializeObject(cl);
                    HttpContent httpContent = new StringContent(Json);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/Json");
                    await httpClient.PostAsync("http://mrsool.1337center.de/api/users1/", httpContent);
                    await DisplayAlert("Added", "Your Data has been added", "OK");
                }
            }
        }
    }
}
