﻿
using FindMyFood.LocalStorage;
using FindMyFood.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FindMyFood.ViewModels
{
   public class OwnFoodListViewModel:BaseViewModel, INotifyPropertyChanged
    {
        public StorageManager SM { get; set; }
        public ICommand PageAppearingCommand { get; private set; }
        private ObservableCollection<Ingredient> _ingredients;
        public ObservableCollection<Ingredient> Ingredients { get { return _ingredients; } set { _ingredients = value; OnPropertyChanged("Ingredients"); } }
        public OwnFoodListViewModel()
        {
            SM = new StorageManager();
            PageAppearingCommand = new Command(OnPageAppearing);
            _ingredients = new ObservableCollection<Ingredient>();

        }

        private void OnPageAppearing()
        {      
            _ingredients = new ObservableCollection<Ingredient>(SM.GetOwnFoodList());
            OnPropertyChanged("Ingredients");
        }
      
       
    }
}