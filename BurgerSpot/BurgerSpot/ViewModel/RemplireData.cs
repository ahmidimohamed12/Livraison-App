using System;
using Firebase.Database;
using BurgerSpot.Model;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;
using Firebase.Database.Query;

namespace BurgerSpot.ViewModel
{
    public class RemplireData
    {
        public FirebaseClient firebase = new FirebaseClient("https://rail-d12e7.firebaseio.com/");
        /*
        public RemplireData()
        {
        }
        public async Task<List<Produits>> getallcategories()
        {

            return (await firebase
              .Child("Categories")
              .OnceAsync<Produits>()).Select(item => new Produits
              {
                  id = item.Object.id,
                  nom = item.Object.nom,
                  prix = item.Object.prix
              }).ToList();
        }

        public async Task addcategories( string name,int prix,string cat)
        {
            await firebase
              .Child("Categories")
              .PostAsync(new Produits() {  nom = name,prix = prix ,ct = cat});
        }

        public async Task<Produits> GetCategorie(int personId)
        {
            var allPersons = await getallcategories();
            await firebase
              .Child("Categories")
              .OnceAsync<Produits>();
            return allPersons.Where(a => a.id == personId).FirstOrDefault();
        }

        public async Task updatecategories(int personId, string name)
        {
            var toUpdatePerson = (await firebase
              .Child("Categories")
              .OnceAsync<Produits>()).Where(a => a.Object.id == personId).FirstOrDefault();

            await firebase
              .Child("Categories")
              .Child(toUpdatePerson.Key)
              .PutAsync(new Produits() { id = personId, nom = name });
        }

        public async Task deletecategories(string personId)
        {
            var toDeletePerson = (await firebase
              .Child("Categories")
              .OnceAsync<Categorie>()).Where(a => a.Object.nom == personId).FirstOrDefault();
            await firebase.Child("Categories").Child(toDeletePerson.Key).DeleteAsync();

        }
        public async Task deletecategories()
        {
            var toDeletePerson = (await firebase
              .Child("Categories")
              .OnceAsync<Categorie>()).ToList();
            await firebase.Child("Categories").DeleteAsync();

        }
        */
    }
}
