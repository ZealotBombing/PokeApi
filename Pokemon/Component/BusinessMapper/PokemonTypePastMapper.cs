using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    internal static class PokemonTypePastMapper
    {
        public static List<PokemonTypePastDto> ToDto(List<PokemonTypePastApiResultDto> pokemonTypePast)
            => pokemonTypePast.Select(ToDto).ToList();
        public static PokemonTypePastDto ToDto(PokemonTypePastApiResultDto typePastsData)
        {
            PokemonTypePastDto dto = new PokemonTypePastDto();

            return dto;
        }
    }
}
