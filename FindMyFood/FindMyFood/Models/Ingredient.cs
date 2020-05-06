using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindMyFood.Models
{
    public class Ingredient
    {
       
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}
