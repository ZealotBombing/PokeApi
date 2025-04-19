using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.DataTransferObject
{
    public class PokemonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Base_experience { get; set; }
        public int Height { get; set; }
        public bool Is_default { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public List<PokemonAbilityDto> Abilities { get; set; }
        public List<PokemonFormTypeDto> Forms { get; set; }

        //TODO: game_indices
        public List<PokemonHeldItemDto> Held_items { get; set; }
        public string Location_area_encounters { get; set; }
        public List<PokemonMoveDto> Moves { get; set; }
        public List<PokemonTypePastDto> Past_types { get; set; }
        public PokemonSpritesDto Sprites { get; set; }
        public string CryAudioSourceLegacy { get; set; }
        public string CryAudioSourceLatest { get; set; }

        //TODO: stats

        public List<PokemonTypeDto> Types { get; set; }
        public string Url { get; set; } //just for list
    }
}
