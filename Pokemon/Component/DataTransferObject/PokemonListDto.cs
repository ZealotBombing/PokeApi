using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.DataTransferObject
{
    public class PokemonListDto
    {
        public int count {  get; set; }
        public string next {  get; set; }
        public string previous { get; set; }
        public List<PokemonDto> pokemons { get; set; }
    }
}
