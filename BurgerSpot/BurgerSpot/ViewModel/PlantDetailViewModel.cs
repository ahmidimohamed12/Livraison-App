using System.Threading.Tasks;
using BurgerSpot.Models;
using BurgerSpot.ViewModel.Base;

namespace BurgerSpot.ViewModel
{
    public class PlantDetailViewModel : ViewModelBase
    {
        private Plant _plant;

        public Plant Plant
        {
            get { return _plant; }
            set
            {
                _plant = value;
                OnPropertyChanged();
            }
        }
        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Plant)
                Plant = (Plant)navigationData;

            return base.InitializeAsync(navigationData);
        }
    }
}