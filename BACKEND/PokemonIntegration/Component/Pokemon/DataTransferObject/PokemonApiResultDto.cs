using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonIntegration.Component.Pokemon.DataTransferObject
{
    public class PokemonApiResultDto
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int base_experience { get; set; }
        public int height { get; set; }
        public bool is_default { get; set; }
        public int order { get; set; }
        public int weight { get; set; }
        public List<PokemonAbilityApiResultDto> abilities { get; set; }
        public List<PokemonFormTypeApiResultDto> forms { get; set; }

        //TODO: game_indices
        public List<PokemonHeldItemApiResultDto> held_items { get; set; }
        public string location_area_encounters { get; set; }
        public List<PokemonMoveApiResultDto> moves { get; set; }
        public List<PokemonTypePastApiResultDto> past_types { get; set; }
        public PokemonSpritesApiResultDto sprites { get; set; }
        public PokemonCriesApiResultDto cries { get; set; }

        //TODO: stats

        public List<PokemonTypeApiResultDto> types { get; set; }

        public string url { get; set; } //Solo para lista
    }
}
