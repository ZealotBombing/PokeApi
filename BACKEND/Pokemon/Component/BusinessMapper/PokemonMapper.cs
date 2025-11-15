using Pokemon.Component.DataTransferObject;
using PokemonIntegration.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Component.BusinessMapper
{
    internal static class PokemonMapper
    {
        public static List<PokemonDto> ToDto( List<PokemonApiResultDto> pokemonDto)
            => pokemonDto.Select(ToDto).ToList();

        public static PokemonDto ToDto(PokemonApiResultDto pokemonApiData)
        {
            PokemonDto dto = new PokemonDto();
            dto.Id = pokemonApiData.id;
            dto.Name = pokemonApiData.name;
            dto.Base_experience = pokemonApiData.base_experience;
            dto.Height = pokemonApiData.height;
            dto.Is_default = pokemonApiData.is_default;
            dto.Order = pokemonApiData.order;
            dto.Weight = pokemonApiData.weight;
            dto.Abilities = pokemonApiData.abilities == null || pokemonApiData.abilities.Count == 0 ? new List<PokemonAbilityDto>() : PokemonAbilityMapper.ToDto(pokemonApiData.abilities);
            dto.Forms = pokemonApiData.forms == null || pokemonApiData.forms.Count == 0 ? new List<PokemonFormTypeDto>() : PokemonFormTypeMapper.ToDto(pokemonApiData.forms);
            dto.Location_area_encounters = pokemonApiData.location_area_encounters;
            dto.Held_items = pokemonApiData.held_items == null || pokemonApiData.held_items.Count ==0 ? new List<PokemonHeldItemDto>() : PokemonHeldItemMapper.ToDto(pokemonApiData.held_items);
            dto.Moves = pokemonApiData.moves == null || pokemonApiData.moves.Count == 0 ? new List<PokemonMoveDto>() : PokemonMoveMapper.ToDto(pokemonApiData.moves);
            dto.Sprites = pokemonApiData.sprites != null ? PokemonSpritesMapper.ToDto(pokemonApiData.sprites) : new PokemonSpritesDto();
            dto.CryAudioSourceLegacy = pokemonApiData.cries == null ? "" : pokemonApiData.cries.legacy;
            dto.CryAudioSourceLatest = pokemonApiData.cries == null ? "" : pokemonApiData.cries.latest;
            dto.Types = pokemonApiData.types == null || pokemonApiData.types.Count == 0 ? new List<PokemonTypeDto>() : PokemonTypeMapper.ToDto(pokemonApiData.types);
            dto.Past_types = pokemonApiData.past_types == null || pokemonApiData.past_types.Count == 0 ? new List<PokemonTypePastDto>() : PokemonTypePastMapper.ToDto(pokemonApiData.past_types);
            dto.Url = pokemonApiData.url;
            return dto;
        }

    }
}
