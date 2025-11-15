using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    internal static class PokemonHeldItemMapper
    {
        public static List<PokemonHeldItemDto> ToDto(List<PokemonHeldItemApiResultDto> pokemonHeldItemDataList)
            => pokemonHeldItemDataList.Select(ToDto).ToList();

        public static PokemonHeldItemDto ToDto(PokemonHeldItemApiResultDto pokemonHeldItemData)
        {
            PokemonHeldItemDto dto = new PokemonHeldItemDto();

            return dto;
        }
    }
}
