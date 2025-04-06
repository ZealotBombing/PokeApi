using Microsoft.AspNetCore.Mvc;
using Pokemon.Component.BusinessImplement;
using Pokemon.Component.DataTransferObject;
using Pokemon.Component.Interfaces;
using Swashbuckle.AspNetCore.Examples;

namespace PokeApi.Areas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        IPokemonImplementation _pokemonImplementation;

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
                var pokemon = await _pokemonImplementation.GetPokemon(pokeId);

                return Ok(pokemon);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new {Message = ex.Message});
            }
        }
        
    }
}
