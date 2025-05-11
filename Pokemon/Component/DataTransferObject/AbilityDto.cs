using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.DataTransferObject
{
    public class AbilityDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool is_main_series { get; set; }
        public AbilityApiResultDto ability { get; set; }
        //TODO: generation
        //TODO: names
        //TODO: effect_entries
        //TODO: effect_changes
        //TODO: flavor_text_entries
        //TODO: pokemon
    }
}
