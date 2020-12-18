using System;
using Xamarin.Forms;
namespace BurgerSpot.Model
{
    public class Produits
    {
        public int idpr { get; set; }
        public string nom { get; set; }
        public string code { get; set; }
        public int prix;
        public string imgp;
        public string img1;
        public string img2;
        public string img3;
        public string descritption;
     //   public string[] Categories = new string[] { "Pharmacies", "Super Marcher",  "Boulangeries","Poissonerie", "Fruits et legumes", "Boucheries", "Jouets pour enfants", "Locations de Voitures", "Resturants", "Hrayfi", "Demand Special","Livres", "Boutique" };
     //   public string ct { get; set; }
       // public int prix;
       // public ImageSource im { get; set; }
        public Produits()
        {

        }
    }
}
