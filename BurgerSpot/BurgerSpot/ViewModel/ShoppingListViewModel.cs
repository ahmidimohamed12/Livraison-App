using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using BurgerSpot.Model;
using BurgerSpot.Services;

namespace BurgerSpot.ViewModel
{
    public class ShoppingListViewModel : BindableObject
    {
        ObservableCollection<ShoppingItem> _items;

        public ShoppingListViewModel()
        {
            LoadShoppingList();
        }

        public ObservableCollection<ShoppingItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        void LoadShoppingList()
        {
            var items = ShoppingService.Instance.GetShoppingList();
            Items = new ObservableCollection<ShoppingItem>(items);
        }
    }
}
