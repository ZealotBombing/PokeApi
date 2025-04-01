

using PokemonIntegration.Component.APIConnection;

namespace TestProject1
{
    internal class PokemonTest
    {
        [Test]
        public void GetPokemon()
        {
            ApiConnection  apiConnection = new ApiConnection();
            apiConnection.GetResponseAsync(); 
        }

    }
}
