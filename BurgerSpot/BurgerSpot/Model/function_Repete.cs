using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Newtonsoft.Json;
using  System.IO;
using Plugin.Connectivity.Abstractions;
namespace BurgerSpot.Model
{
    public static  class function_Repete
    {
        
        public static int connection_status()
        {
            if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected)
            {
                return 1;
            }else
            {
                return 0;
            }
        }
    }

    //get json data
    
}
