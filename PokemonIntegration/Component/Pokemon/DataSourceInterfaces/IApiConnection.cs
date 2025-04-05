using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonIntegration.Component.Pokemon.DataSourceInterfaces
{
    internal interface IApiConnection
    {
        public Task<T> GetResponseAsync<T>(string endPoint);
    }
}
