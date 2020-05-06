using System;
using System.Collections.Generic;
using System.Text;

namespace FindMyFood.Api.Dtos
{
    public class RandomRecipesResponse
    {
        public List<Recipe1> recipes { get; set; }
    }

    public class Recipe1
    {
        public bool vegetarian { get; set; }
        public bool vegan { get; set; }
        public bool glutenFree { get; set; }
        public bool dairyFree { get; set; }
        public bool veryHealthy { get; set; }
        public bool cheap { get; set; }
        public bool veryPopular { get; set; }
        public bool sustainable { get; set; }
        public int weightWatcherSmartPoints { get; set; }
        public string gaps { get; set; }
        public bool lowFodmap { get; set; }
        public int aggregateLikes { get; set; }
        public float spoonacularScore { get; set; }
        public float healthScore { get; set; }
        public string creditsText { get; set; }
        public string license { get; set; }
        public string sourceName { get; set; }
        public float pricePerServing { get; set; }
        public List<Extendedingredient> extendedIngredients { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public int readyInMinutes { get; set; }
        public int servings { get; set; }
        public string sourceUrl { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public string summary { get; set; }
        public List<string> cuisines { get; set; }
        public List<string> dishTypes { get; set; }
        public List<string> diets { get; set; }
        public List<object> occasions { get; set; }
        public Winepairing winePairing { get; set; }
        public string instructions { get; set; }
        public List<Analyzedinstruction> analyzedInstructions { get; set; }
        public object originalId { get; set; }
        public string spoonacularSourceUrl { get; set; }
    }

    public class Winepairing
    {
        public List<string> pairedWines { get; set; }
        public string pairingText { get; set; }
        public List<Productmatch> productMatches { get; set; }
    }

    public class Productmatch
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string imageUrl { get; set; }
        public float averageRating { get; set; }
        public float ratingCount { get; set; }
        public float score { get; set; }
        public string link { get; set; }
    }

    public class Extendedingredient
    {
        public Extendedingredient()
        {

        }
        public int? id { get; set; }
        public string aisle { get; set; }
        public string image { get; set; }
        public string consistency { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string originalString { get; set; }
        public string originalName { get; set; }
        public float amount { get; set; }
        public string unit { get; set; }
        public List<string> meta { get; set; }
        public List<string> metaInformation { get; set; }
        public Measures measures { get; set; }
    }

    public class Measures
    {
        public Us us { get; set; }
        public Metric metric { get; set; }
    }

    public class Us
    {
        public float amount { get; set; }
        public string unitShort { get; set; }
        public string unitLong { get; set; }
    }

    public class Metric
    {
        public float amount { get; set; }
        public string unitShort { get; set; }
        public string unitLong { get; set; }
    }

    public class Analyzedinstruction
    {
        public string name { get; set; }
        public List<Step> steps { get; set; }
    }

    public class Step
    {
        public int number { get; set; }
        public string step { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public List<Equipment> equipment { get; set; }
        public Length length { get; set; }
    }

    public class Length
    {
        public int number { get; set; }
        public string unit { get; set; }
    }

    public class Ingredient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
    }

    public class Equipment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public Temperature temperature { get; set; }
    }

    public class Temperature
    {
        public float number { get; set; }
        public string unit { get; set; }
    }
}

