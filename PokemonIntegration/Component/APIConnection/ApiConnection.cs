using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonIntegration.Component.APIConnection
{
    public class ApiConnection
    {
        public void GetResponseAsync(string endPoint = "pokemon/1")
        {
            using (HttpClient client = new HttpClient())
            {
                Uri baseAddress = new Uri("https://pokeapi.co/api/v2/");
                client.BaseAddress = baseAddress;

                HttpResponseMessage httpResponseMessage = client.GetAsync(endPoint).GetAwaiter().GetResult();

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    string data = client.GetStringAsync(endPoint).GetAwaiter().GetResult(); 
                }

            }
        }

    }
}
