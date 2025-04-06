using Pokemon.Component.DataTransferObject;
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
    }
}
