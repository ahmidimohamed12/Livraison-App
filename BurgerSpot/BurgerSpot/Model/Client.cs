using System;
namespace BurgerSpot.Model
{
    public class Client
    {
        public int id { get; set; }
        public string username { get; set; }
        public string passwords { get; set; }
        public Ville ville { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public string longti { get; set; }
        public string latitu { get; set; }


        public Client()
        {
            id++;
        }
    }
}
