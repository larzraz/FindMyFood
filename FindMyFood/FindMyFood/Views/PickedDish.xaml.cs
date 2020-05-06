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
    public partial class PickedDish : ContentPage
    {
        private readonly SelectedItemChangedEventArgs _recipe;
        public PickedDish(SelectedItemChangedEventArgs e)
        {          
            InitializeComponent();
            _recipe = e;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Der skal sendes et object videre fra sidste page, med alt der skal bruges
            DishGrid.BindingContext = _recipe;
        }
    }
}