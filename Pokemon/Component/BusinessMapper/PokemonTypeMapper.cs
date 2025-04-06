using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    internal static class PokemonTypeMapper
    {
        public static List<PokemonTypeDto> ToDto(List<PokemonTypeApiResultDto> pokemonTypeList)
            => pokemonTypeList.Select(ToDto).ToList();
        public static PokemonTypeDto ToDto(PokemonTypeApiResultDto pokemonTypeData)
        {
            PokemonTypeDto dto = new PokemonTypeDto();
            dto.Slot = pokemonTypeData.slot;
            
            return dto;
        }
    }
}
