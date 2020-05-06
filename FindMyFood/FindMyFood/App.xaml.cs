using FindMyFood.Models;
using FindMyFood.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FindMyFood
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Navigation();
        }

        protected override void OnStart()
        {
            if (!Current.Properties.ContainsKey(StorageRoutes.StorageRoutes.IngredientList))
            {
                Current.Properties.Add(StorageRoutes.StorageRoutes.IngredientList, JsonConvert.SerializeObject(new List<Ingredient>()));
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
