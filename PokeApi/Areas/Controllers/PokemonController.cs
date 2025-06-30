using Microsoft.AspNetCore.Mvc;
using Pokemon.Component.BusinessImplement;
using Pokemon.Component.DataTransferObject;
using Pokemon.Component.Interfaces;
using Swashbuckle.AspNetCore.Filters;
using NLog;
using Microsoft.AspNetCore.Components;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


namespace PokeApi.Areas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        IPokemonImplementation _pokemonImplementation;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public PokemonController(IHttpClientFactory httpClientFactory)
        {
            _pokemonImplementation = new PokemonImplementation(httpClientFactory.CreateClient("PokeApi"));
        }

        [HttpGet("Pokemon")]
        [SwaggerResponseExample(200, typeof(PokemonDto))]
        public async Task<IActionResult> GetPokemon(string pokeId)
        {
            try
            {
                logger.Info($"INFO: getting data of pokemon {pokeId}");

                var pokemon = await _pokemonImplementation.GetPokemon(pokeId);

                logger.Info($"INFO: data of {pokemon.Name.ToUpper()} ready");

                return Ok(pokemon);
            }
            catch (Exception ex)
            {
                logger.Error($"ERROR: {ex.Message}. Stack Trace: {ex.StackTrace}");
                return StatusCode(500, new {Message = ex.Message});
            }
        }

        [HttpGet("PokemonList")]
        [SwaggerResponseExample(200, typeof(List<PokemonDto>))]
        public async Task<IActionResult> GetPokemonList(int offset, int limit)
        {
            try
            {
                logger.Info($"INFO: getting data of pokemon list offset: {offset}, limit {limit}");

                var list = await _pokemonImplementation.GetPokemonList(offset, limit);

                logger.Info($"INFO: data of {list.count} ready");

                return Ok(list);
            }
            catch (Exception ex)
            {
                logger.Error($"ERROR: {ex.Message}. Stack Trace: {ex.StackTrace}");
                return StatusCode(500, new { Message = ex.Message });
            }
        }
    }
}
