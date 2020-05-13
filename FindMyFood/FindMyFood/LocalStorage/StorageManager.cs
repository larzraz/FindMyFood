
using FindMyFood.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FindMyFood.LocalStorage
{
    public static class StorageManager
    {

        public static IList<Ingredient> GetOwnFoodList()
        {
            var s = Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList].ToString();
            return JsonConvert.DeserializeObject<List<Ingredient>>(s);
        }

        public static void DeleteIngredient(Ingredient ingredient)
        {
            var List = GetOwnFoodList();
            List.Remove(List.SingleOrDefault(x => x.Guid == ingredient.Guid));
            Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList] = JsonConvert.SerializeObject(List);
        }

        public static void AddIngredient(Ingredient ingredient){
            var ingredientList = GetOwnFoodList();
            ingredientList.Add(ingredient);
            Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList] = JsonConvert.SerializeObject(ingredientList);
        }
    }
}
