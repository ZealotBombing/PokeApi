using Microsoft.Graph.Models;
using PokemonIntegration.Component.APIConnection;
using PokemonIntegration.Component.Pokemon.DataSourceInterfaces;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using PokemonIntegration.Component.Pokemon.PokeApiEndPointName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonIntegration.Component.Pokemon.DataSourceImplement
{
    public class PokemonApiConnectionImpl : IPokemonApiConnectionImpl
    {
        private readonly IApiConnection _apiConnection;

        public PokemonApiConnectionImpl()
        {
            _apiConnection = new ApiConnection();
        }

        public async Task<PokemonApiResultDto> GetPokemon(string pokeId) {

            var pokemon = await _apiConnection
                .GetResponseAsync<PokemonApiResultDto>($"{PokeApiEndPointName.PokeApiEndPointName.PokemonEndonpint}{pokeId}");

            return pokemon; 
        
        }

        public async Task<PokemonApiResultListDto> GetPokemonList(int offset, int limit)
        {
            var pokemon = await _apiConnection
                .GetResponseAsync<PokemonApiResultListDto>
                ($"{PokeApiEndPointName.PokeApiEndPointName.PokemonEndonpint}?offset={offset}&limit={limit}");
            return pokemon;
        }


        public async Task<string> GetSprite(string url)
            => await _apiConnection.GetSprite(url);
    }
}
