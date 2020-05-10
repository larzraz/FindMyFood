using FindMyFood.Api.Dtos;
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
    public partial class PickedDish : ContentPage
    {
        private readonly Recipe _recipe;

        public PickedDish(Recipe e)
        {          
            InitializeComponent();
            _recipe = e;
            BindingContext = _recipe;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}