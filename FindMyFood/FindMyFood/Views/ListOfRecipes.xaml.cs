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
        public ListOfRecipes()
        {
            InitializeComponent();
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