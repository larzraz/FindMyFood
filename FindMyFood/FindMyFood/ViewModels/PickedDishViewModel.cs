using FindMyFood.Api;
using FindMyFood.Api.Dtos;
using FindMyFood.LocalStorage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FindMyFood.ViewModels
{
    public class PickedDishViewModel:BaseViewModel
    {
        private Recipe _recipe;
        public Recipe Recipe { get { return _recipe; } set { _recipe = value; } }
        public Instruction Instruction { get; set; }
        public ICommand PageAppearingCommand { get; private set; }
        private SpoonacularApiClient _api = new SpoonacularApiClient();

        public PickedDishViewModel()
        {
            _recipe = Store.SelectedRecipe;
            PageAppearingCommand = new Command(OnPageAppearing);
           
        }

        private async void OnPageAppearing()
        {
            Instruction = (await _api.GetInstructions(_recipe.Id));
            OnPropertyChanged(nameof(Instruction));

        }
    }
}
