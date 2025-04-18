using Microsoft.Graph.Models;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonIntegration.Component.Pokemon.DataSourceInterfaces
{
    public interface IPokemonApiConnectionImpl
    {
        public Task<PokemonApiResultDto> GetPokemon(string pokeId);
        public Task<PokemonApiResultListDto> GetPokemonList(int offset, int limit);
    }
}
