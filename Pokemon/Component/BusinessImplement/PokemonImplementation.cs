using PokemonIntegration.Component.Pokemon.DataSourceImplement;
using PokemonIntegration.Component.Pokemon.DataSourceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessImplement
{
    public class PokemonImplementation
    {
        private IPokemonApiConnectionImpl _pokemonApiConnectionImpl;

        public PokemonImplementation() {

            _pokemonApiConnectionImpl = new PokemonApiConnectionImpl();

        }

        public object GetPokemon(string pokeId)
        {
            

            return new { };
        }
    }
}
