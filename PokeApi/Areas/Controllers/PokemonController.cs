using Microsoft.AspNetCore.Mvc;
using Pokemon.Component.BusinessImplement;
using Pokemon.Component.DataTransferObject;
using Pokemon.Component.Interfaces;
using Swashbuckle.AspNetCore.Filters;
using NLog;


namespace PokeApi.Areas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        IPokemonImplementation _pokemonImplementation;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public PokemonController()
        {
            _pokemonImplementation = new PokemonImplementation();
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
        
    }
}
