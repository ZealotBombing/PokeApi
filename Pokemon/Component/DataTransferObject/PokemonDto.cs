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
        public List<PokemonHeldItemApiResultDto> Held_items { get; set; }
        public string Location_area_encounters { get; set; }
        public List<PokemonMoveApiResultDto> Moves { get; set; }
        public List<PokemonTypePastApiResultDto> Past_types { get; set; }
        public PokemonSpritesApiResultDto Sprites { get; set; }
        public string CryAudioSource { get; set; }

        //TODO: stats

        public List<PokemonTypeApiResultDto> types { get; set; }
    }
}
