using System;
using System.Collections.Generic;
using BurgerSpot.Model;
using BurgerSpot.Services;
using System.Linq;
using System.Net.Http;
using System.Net;
using BurgerSpot.ViewModel;
using Xamarin.Forms;
using System.Net.Http.Headers;

namespace BurgerSpot.Views
{
    public partial class Logins : ContentPage
    {
        public Logins()
        {
            InitializeComponent();
            if (constants.france == 1)
            {
                txtlo.Text = "Log in"; 
                txtsauvg.Text = "";
                txtpassword.Placeholder = "Mot de Passe";
                txtusername.Placeholder = "Nom Complete";
               
            }
            if (constants.arabe == 1)
            {
                txtlo.Text = "تسجيل الدخول";
                txtlo.HorizontalOptions = LayoutOptions.Center;
                txtusername.Placeholder = "البريد الإلكتروني";
                txtpassword.Placeholder = "الرقم السري";
                txtsauvg.Text = "تسجيل";
            }
            var n = new TapGestureRecognizer();
            n.Tapped += btn_clicklog;

            grsi.GestureRecognizers.Add(n);

            var nn = new TapGestureRecognizer();
            nn.Tapped += async (s, e) =>
            {
                await Navigation.PushModalAsync(new MyPage_registration());
            };
            txtsauvg.GestureRecognizers.Add(nn);

        }

        private async void btn_clicklog(object sender,EventArgs e)
        {
            
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri("http://mrsool.1337center.de/api/users1");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("http://mrsool.1337center.de/api/users1").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                //database
                List<Client> ss = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Client>>(result);
                var usp = txtpassword.Text;
                var names = txtusername.Text;
                int pp = 0;
                for (int i = 0; i < ss.Count; i++)
                {
                    if (names == ss[i].username && usp == ss[i].passwords)
                    {
                        pp = 1;
                        break;
                    }
                }
                if (pp == 1)
                    await Navigation.PushModalAsync(new BurgerSpot.Views.Clients.MyPage_swipe());
               
        }
        private async void btn_sign(object sender,EventArgs E)
        {
           // await Navigation.PushModalAsync(new MyPage_registration());
        }
    }
}
