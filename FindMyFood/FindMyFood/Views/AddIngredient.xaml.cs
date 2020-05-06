using FindMyFood.StorageRoutes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMyFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddIngredient : ContentPage
    {
        public AddIngredient()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var ingredientList = JsonConvert.DeserializeObject<List<string>>(Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList].ToString());
            ingredientList.Add(IngredientName.Text);
            Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList] = JsonConvert.SerializeObject(ingredientList);
            await Navigation.PopModalAsync();
        }
    }
}