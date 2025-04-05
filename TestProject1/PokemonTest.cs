using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using PokeApi;

using PokemonIntegration.Component.APIConnection;

namespace TestProject1
{
    internal class PokemonTest
    {
        [Test]
        public void GetPokemon()
        {
            var settings = new ApiSettings() { PokeApiHost = "https://pokeapi.co/api/v2/" };
            var options = Options.Create(settings);
            var apiConnection = new ApiConnection(options);

            var data = apiConnection.GetResponseAsync("pokemon/1").GetAwaiter().GetResult(); 
        }

    }
}
