using FindMyFood.Api.Dtos;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FindMyFood.Api
{
    public class SpoonacularApiClient
    {
        private RestClient _client;
        private const string apiKey = "06395642d03844fbba0d80736b0b13f1";
        private const string Separator = ",+";

        public SpoonacularApiClient()
        {
            _client = new RestClient("https://api.spoonacular.com/");
            _client.DefaultParameters.Add(new Parameter("apiKey", apiKey, ParameterType.QueryString));
        }

        /// <summary>
        /// Get randoms recipes
        /// </summary>
        /// <param name="limitLicense"></param>
        /// <param name="numberOfRecipes"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public async Task<List<Recipe1>> GetRandomRecipes(bool limitLicense = true, int numberOfRecipes = 5, params string[] tags)
        {
            var request = new RestRequest("recipes/random")
                .AddParameter("limitLicense", limitLicense)
                .AddParameter("tags", string.Join(Separator, tags))
                .AddParameter("number", numberOfRecipes);
            var response = await _client.ExecuteAsync<RandomRecipesResponse>(request);
            return response.Data.recipes;
        }

        public async Task<List<Recipe>> GetRecipesByIngredients(bool limitLicense = true, int numberOfRecipes = 10, int ranking = 1, bool ignorePantry = true, params string[] ingredients)
        {
            var ingre = string.Join(Separator, ingredients);
            var request = new RestRequest("recipes/findByIngredients")
                .AddParameter("limitLicense", limitLicense)
                .AddParameter("ranking", ranking)
                .AddParameter("ignorePantry", ignorePantry)
                .AddParameter("ingredients", ingre)
                .AddParameter("number", numberOfRecipes);
            var response = await _client.ExecuteAsync<List<Recipe>>(request);
            return response.Data;
        }

        public async Task<List<Instruction>> GetInstructions(int recipeId)
        {
            var request = new RestRequest($"recipes/{recipeId}/analyzedInstructions");
            var response = await _client.ExecuteAsync<List<Instruction>>(request);
            return response.Data;
        }
    }

    public class Instruction
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
    }

}
