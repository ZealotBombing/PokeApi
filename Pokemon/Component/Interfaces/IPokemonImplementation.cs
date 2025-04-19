using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.Interfaces
{
    public interface IPokemonImplementation
    {
        public Task<PokemonDto> GetPokemon(string pokeId);
        public Task<PokemonListDto> GetPokemonList(int offset, int limit);
        public Task<string> GetSprite(PokemonDto pokemon);
    }
}
