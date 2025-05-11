using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    internal static class PokemonAbilityMapper
    {
        public static List<PokemonAbilityDto> ToDto(List<PokemonAbilityApiResultDto> ablitityList)
            => ablitityList.Select(ToDto).ToList();
        public static PokemonAbilityDto ToDto(PokemonAbilityApiResultDto abilityApiDataa)
        {
            PokemonAbilityDto dto = new PokemonAbilityDto();
            dto.id = abilityApiDataa.id;
            dto.name = abilityApiDataa.name;
            dto.is_main_series = abilityApiDataa.is_main_series;
            
            return dto;
        }
    }
}
