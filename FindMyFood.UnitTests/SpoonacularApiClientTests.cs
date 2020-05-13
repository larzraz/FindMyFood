using FindMyFood.Api;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FindMyFood.UnitTests
{
    public class SpoonacularApiClientTests
    {
        private SpoonacularApiClient _api;

        [SetUp]
        public void Setup()
        {
            _api = new SpoonacularApiClient();
        }

        [Test]
        public async Task Test_Get_Instructions()
        {
            const int recipeId = 633338;
            var result = await _api.GetInstructions(recipeId);
            Assert.IsNotNull(result);
        }
    }
}