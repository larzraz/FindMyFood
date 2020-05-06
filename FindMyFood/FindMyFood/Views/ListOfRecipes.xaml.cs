using FindMyFood.Api;
using FindMyFood.Api.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMyFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListOfRecipes : ContentPage
    {
        private SpoonacularApiClient _api;

        public ListOfRecipes()
        {
            _api = new SpoonacularApiClient();
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var ingredients = JsonConvert.DeserializeObject<List<Models.Ingredient>>(Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList].ToString());
            var listIngredients = ingredients.Select(x => x.Name).ToArray();
            if (listIngredients.Length > 0)
            {
                ListView_Recipes.ItemsSource = new ObservableCollection<Recipe>(await _api.GetRecipesByIngredients(ingredients: listIngredients));
            }
        }

        private void ListView_Recipes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }

            Navigation.PushAsync(new PickedDish(e));
        }
    }
}