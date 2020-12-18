using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using BurgerSpot.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XFDelivery.Views;
using BurgerSpot.Services;
using BurgerSpot.Model;
using BurgerSpot;


namespace XFDelivery.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            NavigateToDetailPageCommand = new Command<Item>(async (model) => await ExecuteNavigateToDetailPageCommand(model));
            SelectGroupCommand = new Command<Group>((model) => ExecuteSelectGroupCommand(model));
            GetGroups();
            GetItems();
        }

        public Command SelectGroupCommand { get; }
        public Command NavigateToDetailPageCommand { get; }
        public ObservableCollection<Group> Groups { get; set; }
        public ObservableCollection<Item> Items { get; set; }

        void GetGroups()
        {
            Groups = new ObservableCollection<Group>(DataService.GetGroups());
        }

        void GetItems()
        {
            Items = new ObservableCollection<Item>(DataService.GetItems());
        }

        private async Task ExecuteNavigateToDetailPageCommand(Item model)
        {
           // await Navigaton.PushAsync(new DetailPage(model));
        }

        private void ExecuteSelectGroupCommand(Group model)
        {
            var index = Groups
                .ToList()
                .FindIndex(p => p.description == model.description);

            if (index > -1)
            {
                UnselectGroupItems();

                Groups[index].selected = true;
                Groups[index].backgroundColor = Color.FromHex("#FF8920");
            }
        }

        void UnselectGroupItems()
        {
            Groups.ForEach((item) =>
            {
                item.selected = false;
                item.backgroundColor = Color.FromHex("#FFFFFF");
            });
        }
    }
}
