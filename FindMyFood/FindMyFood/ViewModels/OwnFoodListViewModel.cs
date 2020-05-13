
using FindMyFood.LocalStorage;
using FindMyFood.Models;
using FindMyFood.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FindMyFood.ViewModels
{
   public class OwnFoodListViewModel:BaseViewModel
    {

        public ICommand PageAppearingCommand { get; private set; }
        public ICommand AddIngredientCommand => new Command(AddIngredient);
        public ICommand RemoveIngredientCommand => new Command<Ingredient>(RemoveIngredient); 
        public ObservableCollection<Ingredient> Ingredients { get; set;  }
        public OwnFoodListViewModel()
        {

            PageAppearingCommand = new Command(OnPageAppearing);
            Ingredients = new ObservableCollection<Ingredient>();

        }
        private async void AddIngredient()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new AddIngredient());
        }
        private void RemoveIngredient(Ingredient obj)
        {
            StorageManager.DeleteIngredient(obj);
            Ingredients = new ObservableCollection<Ingredient>(StorageManager.GetOwnFoodList());
            OnPropertyChanged(nameof(Ingredients));
        }

        private void OnPageAppearing()
        {
            Ingredients = new ObservableCollection<Ingredient>(StorageManager.GetOwnFoodList());
            OnPropertyChanged(nameof(Ingredients));
        }
    }
}
