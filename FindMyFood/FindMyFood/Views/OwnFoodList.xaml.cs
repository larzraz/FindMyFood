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
    public partial class OwnFoodList : ContentPage
    {
        public OwnFoodList()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddIngredient());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FoodList.ItemsSource = JsonConvert.DeserializeObject<List<string>>(Application.Current.Properties[StorageRoutes.StorageRoutes.IngredientList].ToString());
        }
    }
}