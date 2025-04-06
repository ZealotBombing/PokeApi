using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    internal static class PokemonSpritesMapper
    {
        public static PokemonSpritesDto ToDto(PokemonSpritesApiResultDto pokemonSpritesData)
        {
            PokemonSpritesDto dto = new PokemonSpritesDto();
            dto.Front_default = pokemonSpritesData.front_default;
            dto.Front_shiny = pokemonSpritesData.front_shiny;
            dto.Front_female = pokemonSpritesData.front_female;
            dto.Front_shiny_female = pokemonSpritesData.front_shiny_female;
            dto.Back_shiny = pokemonSpritesData.back_shiny;
            dto.Back_female = pokemonSpritesData.back_female;
            dto.Back_shiny_female = pokemonSpritesData.back_shiny_female;

            return dto;
            
        }
    }
}
