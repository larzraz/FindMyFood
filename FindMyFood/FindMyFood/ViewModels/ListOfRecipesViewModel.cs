using FindMyFood.Api;
using FindMyFood.Api.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FindMyFood.ViewModels
{
    public class ListOfRecipesViewModel:BaseViewModel
    {
        private SpoonacularApiClient _api;
        public bool IsLoading { get; set; }
        public ICommand PageAppearingCommand { get; private set; }
        private ObservableCollection<Recipe> _recipes;
        public ObservableCollection<Recipe> Recipes { get => _recipes; set { _recipes = value; OnPropertyChanged(nameof(Recipes)); } }
        public ListOfRecipesViewModel()
        {
            _api = new SpoonacularApiClient();
            PageAppearingCommand = new Command(OnPageAppearing);
            _recipes = new ObservableCollection<Recipe>();
    }

        private async void OnPageAppearing()
        {
            IsLoading = true;
            var ingredients = JsonConvert.DeserializeObject<List<Models.Ingredient>>(Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList].ToString());
            var listIngredients = ingredients.Select(x => x.Name).ToArray();
            if (listIngredients.Length > 0)
            {
                OnPropertyChanged(nameof(IsLoading));
                _recipes = new ObservableCollection<Recipe>(await _api.GetRecipesByIngredients(ingredients: listIngredients));
                IsLoading = false;
            }
            OnPropertyChanged(nameof(Recipes));
            OnPropertyChanged(nameof(IsLoading));
        }
    }
}
