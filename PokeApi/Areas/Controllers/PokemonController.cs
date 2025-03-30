using Microsoft.AspNetCore.Mvc;

namespace PokeApi.Areas.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        [HttpGet("Pokemon")]
        public IEnumerable<String> GetStrings()
        {
            return new string[] { "Fernanda", "Piña" };
        }
        
    }
}
