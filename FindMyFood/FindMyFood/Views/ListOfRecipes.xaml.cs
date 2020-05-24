
using FindMyFood.Api.Dtos;
using FindMyFood.LocalStorage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMyFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListOfRecipes : ContentPage
    {
        public ListOfRecipes()
        {
            InitializeComponent();
        }

        private void ListView_Recipes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            Store.SelectedRecipe = (Recipe)e.SelectedItem;

            Navigation.PushAsync(new PickedDish());
        }
    }
}