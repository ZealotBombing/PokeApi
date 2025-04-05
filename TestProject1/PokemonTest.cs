using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using PokeApi;

using PokemonIntegration.Component.APIConnection;
using PokemonIntegration.Component.Pokemon.DataTransferObject;

namespace TestProject1
{
    internal class PokemonTest
    {
        [Test]
        public void GetPokemon()
        {
            
            var apiConnection = new ApiConnection();

            PokemonApiResultDto data = apiConnection.GetResponseAsync<PokemonApiResultDto>("pokemon/1").GetAwaiter().GetResult();

            var prop = data.
        }

    }
}
