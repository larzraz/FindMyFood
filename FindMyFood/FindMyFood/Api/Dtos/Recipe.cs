using System;
using System.Collections.Generic;
using System.Text;

namespace FindMyFood.Api.Dtos
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string imageType { get; set; }
        public int usedIngredientCount { get; set; }
        public int missedIngredientCount { get; set; }
        public List<Missedingredient> missedIngredients { get; set; }
        public List<Usedingredient> usedIngredients { get; set; }
        public List<Unusedingredient> unusedIngredients { get; set; }
        public int likes { get; set; }
    }

    public class Missedingredient
    {
        public int id { get; set; }
        public float amount { get; set; }
        public string unit { get; set; }
        public string unitLong { get; set; }
        public string unitShort { get; set; }
        public string aisle { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string originalString { get; set; }
        public string originalName { get; set; }
        public string image { get; set; }
        public string extendedName { get; set; }
    }

    public class Usedingredient
    {
        public int id { get; set; }
        public float amount { get; set; }
        public string unit { get; set; }
        public string unitLong { get; set; }
        public string unitShort { get; set; }
        public string aisle { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string originalString { get; set; }
        public string originalName { get; set; }
        public string image { get; set; }
        public string extendedName { get; set; }
    }

    public class Unusedingredient
    {
        public int id { get; set; }
        public float amount { get; set; }
        public string unit { get; set; }
        public string unitLong { get; set; }
        public string unitShort { get; set; }
        public string aisle { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string originalString { get; set; }
        public string originalName { get; set; }
        public string image { get; set; }
    }
}
