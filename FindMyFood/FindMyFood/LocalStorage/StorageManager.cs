
using FindMyFood.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FindMyFood.LocalStorage
{
    public class StorageManager
    {
        public StorageManager()
        {

        }

        public IList<Ingredient> GetOwnFoodList()
        {
            var s = Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList].ToString();
            return JsonConvert.DeserializeObject<List<Ingredient>>(s);
        }
    }
}
