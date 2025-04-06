using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    public static class PokemonMapper
    {
        public static PokemonDto ToDto(PokemonApiResultDto pokemonApiData)
        {
            PokemonDto dto = new PokemonDto();
            dto.Id = pokemonApiData.id;
            dto.Name = pokemonApiData.name;
            dto.Base_experience = pokemonApiData.base_experience;
            dto.Is_default = pokemonApiData.is_default;
            dto.Order = pokemonApiData.order;
            dto.Weight = pokemonApiData.weight;

            return dto;
        }

    }
}
