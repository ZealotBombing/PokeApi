using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.DataTransferObject
{
    public class PokemonAbilityDto
    {
        public int id { get; set; }

        public string name { get; set; }
        public bool is_main_series { get; set; }
        //TODO: generation
        //TODO: names
        //TODO: effect_entries
        //TODO: effect_changes
        //TODO: flavor_text_entries
        //TODO: pokemon
    }
}
