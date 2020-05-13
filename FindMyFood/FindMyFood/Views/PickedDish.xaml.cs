using FindMyFood.Api.Dtos;
using FindMyFood.ViewModels;
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

       
        public PickedDish()
        {          
            InitializeComponent();      
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}