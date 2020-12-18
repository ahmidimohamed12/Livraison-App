using System;
using System.Collections.Generic;
using System.Linq;
using CarouselView.FormsPlugin.iOS;
using Xamarin.Forms;
using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace BurgerSpot.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();

            Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.Forms.Init();

            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            Lottie.Forms.iOS.Renderers.AnimationViewRenderer.Init();
            CarouselView.FormsPlugin.iOS.CarouselViewRenderer.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
