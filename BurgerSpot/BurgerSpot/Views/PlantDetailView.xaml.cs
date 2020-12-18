using Xamarin.Forms;

namespace BurgerSpot.Views
{
    public partial class PlantDetailView : ContentPage
    {
        public PlantDetailView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Parallax.ParallaxView = HeaderView;
        }
    }
}