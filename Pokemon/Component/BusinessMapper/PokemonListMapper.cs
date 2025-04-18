using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    public static class PokemonListMapper
    {
        public static PokemonListDto ToDto(PokemonApiResultListDto pokemonApiResultListDto)
        {
            PokemonListDto pokemonListDto = new PokemonListDto();
            pokemonListDto.count = pokemonApiResultListDto.count;
            pokemonListDto.next = pokemonApiResultListDto.next;
            pokemonListDto.previous = pokemonApiResultListDto.previous;
            pokemonListDto.pokemons = PokemonMapper.ToDto(pokemonApiResultListDto.results);

            return pokemonListDto;
        }
    }
}
