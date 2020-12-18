using System.Threading.Tasks;
using Xamarin.Forms;

namespace BurgerSpot.ViewModel.Base
{

    public class ViewModelBase : BindableObject
    {
        public virtual Task InitializeAsync(object navigationData) => Task.FromResult(false);
    }
}
