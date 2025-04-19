using Pokemon.Component.BusinessMapper;
using Pokemon.Component.DataTransferObject;
using Pokemon.Component.Interfaces;
using PokemonIntegration.Component.Pokemon.DataSourceImplement;
using PokemonIntegration.Component.Pokemon.DataSourceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessImplement
{
    public class PokemonImplementation : IPokemonImplementation
    {
        private IPokemonApiConnectionImpl _pokemonApiConnectionImpl;

        public PokemonImplementation() {

            _pokemonApiConnectionImpl = new PokemonApiConnectionImpl();

        }

        public async Task<PokemonDto> GetPokemon(string pokeId)
            => PokemonMapper.ToDto(await _pokemonApiConnectionImpl.GetPokemon(pokeId));

        public async Task<PokemonListDto> GetPokemonList(int offset, int limit)
            => PokemonListMapper.ToDto(await _pokemonApiConnectionImpl.GetPokemonList(offset, limit));

        public async Task<string> GetSprite(PokemonDto pokemon)
            => await _pokemonApiConnectionImpl.GetSprite(pokemon.Url);
    }
}
