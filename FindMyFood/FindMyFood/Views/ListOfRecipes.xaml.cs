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
        private ObservableCollection<Recipe1> recipes = new ObservableCollection<Recipe1>();

        public ListOfRecipes()
        {
            _api = new SpoonacularApiClient();
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ListView_Recipes.ItemsSource = recipes;
            if (recipes.Count == 0)
            {
                foreach (var recipe in await _api.GetRandomRecipes(numberOfRecipes: 20))
                {
                    recipes.Add(recipe);
                }
            }
        }
    }
}