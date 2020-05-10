using FindMyFood.Api.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FindMyFood.ViewModels
{
    public class PickedDishViewModel
    {
        private Recipe _recipe;
        public Recipe Recipe { get { return _recipe; } set { _recipe = value; } }

        public PickedDishViewModel(Recipe e)
        {
            _recipe = e;
        }
    }
}
