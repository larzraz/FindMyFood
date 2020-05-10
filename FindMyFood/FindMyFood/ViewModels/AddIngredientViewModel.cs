using FindMyFood.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FindMyFood.ViewModels
{
    public class AddIngredientViewModel:BaseViewModel
    {

        public ICommand SubmitCommand => new Command(Submit);
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Quantity { get; set; }

        public AddIngredientViewModel()
        {
            ExpirationDate = DateTime.Now;
        }

        private async void Submit()
        {
            var ingredientList = JsonConvert.DeserializeObject<List<Ingredient>>(Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList].ToString());
            var addedIngredient = new Ingredient { Name = Name, ExpirationDate = ExpirationDate.Date, Quantity = Int32.Parse(Quantity), Guid = Guid.NewGuid() };
            ingredientList.Add(addedIngredient);
            Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList] = JsonConvert.SerializeObject(ingredientList);
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
