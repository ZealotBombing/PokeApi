using System.Threading.Tasks;
using PokeApi;

using PokemonIntegration.Component.APIConnection;

namespace TestProject1
{
    internal class PokemonTest
    {
        private readonly MyService _myService;

        [Test]
        public void GetPokemon()
        {
            ApiConnection  apiConnection = new ApiConnection();
            var data = apiConnection.GetResponseAsync("pokemon/1").GetAwaiter().GetResult(); 
        }

    }
}
