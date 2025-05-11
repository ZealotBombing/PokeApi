using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    public static class TypeMapper
    {
        public static List<TypeDto> ToDto(List<TypeApiResultDto> entities)
            => entities.Select(ToDto).ToList();
        public static TypeDto ToDto(TypeApiResultDto entity)
        {
            TypeDto dto = new TypeDto();
            dto.id = entity.id;
            dto.name = entity.name;

            return dto;
        }
    }
}
