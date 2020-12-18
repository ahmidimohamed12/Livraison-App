using System;
using Firebase.Database.Query;
using Firebase.Database;
using Xamarin.Forms;
namespace BurgerSpot.Model
{
    public class Categorie
    { 
        public int id { get; set; }
        public string nom { get; set; }
       
        public Categorie()
        {
        }
    }
}
