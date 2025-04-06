using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    internal static class PokemonMoveMapper
    {
        public static List<PokemonMoveDto> ToDto(List<PokemonMoveApiResultDto> pokemonMoveDataList)
            => pokemonMoveDataList.Select(ToDto).ToList();
        public static PokemonMoveDto ToDto(PokemonMoveApiResultDto pokemonMoveData)
        {
            PokemonMoveDto dto = new PokemonMoveDto();
            return dto;
        }
    }
}
