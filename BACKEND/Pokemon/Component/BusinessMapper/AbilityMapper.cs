using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    public static class AbilityMapper
    {
        public static List<AbilityDto> ToDto(List<AbilityApiResultDto> entities)
        {
            return entities.Select(ToDto).ToList();
        }
        public static AbilityDto ToDto(AbilityApiResultDto entiy)
        {
            AbilityDto dto = new AbilityDto();
            dto.id = entiy.id;
            dto.name = entiy.name;
            dto.is_main_series = entiy.is_main_series;
            
            return dto;
        }
    }
}
