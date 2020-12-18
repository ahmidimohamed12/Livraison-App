using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using System.IO;
using Newtonsoft.Json;
using BurgerSpot.Model;
using System.Reflection;

namespace BurgerSpot.Views
{
    public partial class MyPage_ville : ContentPage
    {
        public MyPage_ville()
        {
            InitializeComponent();
            getjsondata("villemaroc.json");
        }
        public void getjsondata(string filename)
        {
           

         //   string jsonFileName = filename;
            // ContactList ObjContactList = new ContactList();
           // Ville ville = new Ville();
            //var assembly = typeof(MyPage_ville).GetTypeInfo().Assembly;
            //Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
         //   using (var reader = new System.IO.StreamReader(stream))
            //{
              //  var jsonString = reader.ReadToEnd();

                //Converting JSON Array Objects into generic list    
                //ville = JsonConvert.DeserializeObject<Ville>(jsonString);
            //}
            //Binding listview with json string     
            //ls.ItemsSource = ville.ville;
        }
    }
}
