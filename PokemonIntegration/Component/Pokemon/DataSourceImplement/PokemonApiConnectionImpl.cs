using PokemonIntegration.Component.APIConnection;
using PokemonIntegration.Component.Pokemon.DataSourceInterfaces;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonIntegration.Component.Pokemon.DataSourceImplement
{
    public class PokemonApiConnectionImpl
    {
        private readonly IApiConnection _apiConnection;

        public PokemonApiConnectionImpl()
        {
            _apiConnection = new ApiConnection();
        }

        public PokemonApiResultDto GetPokemon() { 


            return new PokemonApiResultDto(); 
        
        }

    }
}
