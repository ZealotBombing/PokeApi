using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    internal static class PokemonFormTypeMapper
    {
        public static List<PokemonFormTypeDto> ToDto(List<PokemonFormTypeApiResultDto> pokemonFormTypeDataList)
            => pokemonFormTypeDataList.Select(ToDto).ToList();

        public static PokemonFormTypeDto ToDto(PokemonFormTypeApiResultDto pokemonFormTypeData)
        {
            PokemonFormTypeDto dto = new PokemonFormTypeDto();
            dto.Slot = pokemonFormTypeData.slot;

            return dto;
        }
    }
}
