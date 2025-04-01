using Microsoft.Extensions.Options;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using PokeApi;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace PokemonIntegration.Component.APIConnection
{
    public class ApiConnection
    {
        private readonly MySettings _settings;

        public ApiConnection(IOptions<MySettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task<string> GetResponseAsync(string endPoint)
        {

            using (HttpClient client = new HttpClient())
            {
                Uri baseAddress = new Uri(_settings.ApiUrl);
                client.BaseAddress = baseAddress;

                HttpResponseMessage httpResponseMessage = await client.GetAsync(endPoint);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string data = await client.GetStringAsync(endPoint);

                    return data;
                }

                throw new Exception("Error in request");
            }
        }

    }
}
