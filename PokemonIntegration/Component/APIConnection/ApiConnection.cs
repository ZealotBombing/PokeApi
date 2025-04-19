using Microsoft.Graph;
using Microsoft.Graph.Models;
using Newtonsoft.Json;
using PokemonIntegration.Component.Pokemon.DataSourceInterfaces;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using PokemonIntegration.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokemonIntegration.Component.APIConnection
{
    public class ApiConnection: IApiConnection
    {
        private readonly string _pokeHost;

        public ApiConnection()
        {
            _pokeHost = ClientConfigReader.GetApiHost();
        }

        public async Task<T> GetResponseAsync<T>(string endPoint)
        {
            using (HttpClient pokeClient = new HttpClient())
            {
                Uri baseAddress = new Uri(_pokeHost);
                pokeClient.BaseAddress = baseAddress;

                HttpResponseMessage httpResponseMessage = await pokeClient.GetAsync(endPoint);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string pokeJson = await httpResponseMessage.Content.ReadAsStringAsync();
                    
                    var pokeData = JsonConvert.DeserializeObject<T>(pokeJson);

                    return pokeData;
                }

                throw new Exception("Error in request");
            }
        }

        public async Task<String> GetSprite(string pokeUrl)
        {
            using (HttpClient pokeClient = new HttpClient())
            {
                Uri baseAddress = new Uri(pokeUrl);
                pokeClient.BaseAddress = baseAddress;

                HttpResponseMessage httpResponseMessage = await pokeClient.GetAsync(pokeUrl);

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string pokeJson = await httpResponseMessage.Content.ReadAsStringAsync();

                    var pokeSprite = JsonConvert.DeserializeObject<PokemonApiResultDto>(pokeJson).sprites.front_default;

                    return pokeSprite;
                }

                throw new Exception("Error in request");
            }
        }

    }
}
