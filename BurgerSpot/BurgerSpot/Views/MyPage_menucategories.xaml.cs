using System;
using BurgerSpot.Model;
using BurgerSpot.ViewModel;
using BurgerSpot.Converters;
using System.Collections.Generic;
using ButtonCircle.FormsPlugin.Abstractions;
using Xamarin.Forms;
using System.Linq;

namespace BurgerSpot.Views
{
    public partial class MyPage_menucategories : ContentPage
    {
        private List<Color> _backgroundColors = new List<Color>();

        public  static int btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12;

        public MyPage_menucategories()
        {
            InitializeComponent();


            if (constants.arabe == 1)
            {
                txtphar.Text = "الأدوية";
                txtmercado.Text = "سوق ممتاز";
                txtboulangeri.Text = "مخبزة";
                txtpoisson.Text = "بائع السمك";
                txtfruits.Text = "الخظر و الفواكه";
                txtbouch.Text = "بائع اللحم";
                txtjouetenfant.Text = "ألعاب أطفال";
                txtlocation.Text = "كراء السيارات";
                txtrestaurant.Text = "مطعم";
                txthrayfi.Text = "حرفي";
                txtspecial.Text = "خاصة";
                txtlivre.Text = "كتب و جرائد";
                txtboutique.Text = "محلآات";
                
            }
            if (constants.france == 1)
            {
                txtphar.Text = "Pharmacies";
                txtmercado.Text = "Super Marcher";
                txtboulangeri.Text = "Boulangeries";
                txtpoisson.Text = "Poissonerie";
                txtfruits.Text = "Fruits et legumes";
                txtbouch.Text = "Boucheries";
                txtjouetenfant.Text = "Jouets pour enfants";
                txtlocation.Text = "Locations de Voitures";
                txtrestaurant.Text = "Resturants";
                txthrayfi.Text = "Hrayfi";
                txtspecial.Text = "Demand Special";
                txtlivre.Text = "Livres";
                txtboutique.Text = "Boutique";
            }

            txtphar.Clicked += btn_click;

            
        }


        private   void btn_clickguest(Button btn,EventHandler e)
        {
            var n = new TapGestureRecognizer();
            n.Tapped += e;
            btn.GestureRecognizers.Add(n);



        }

        private async void btn_click(object sender,EventArgs e)
        {  
         await  Navigation.PushModalAsync(new MyPage_listshopbindigs());
        }
    }
}
