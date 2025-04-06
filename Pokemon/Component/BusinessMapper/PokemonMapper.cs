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
            dto.Abilities = PokemonAbilityMapper.ToDto(pokemonApiData.abilities);
            dto.Forms = PokemonFormTypeMapper.ToDto(pokemonApiData.forms);
            dto.Location_area_encounters = pokemonApiData.location_area_encounters;
            dto.Held_items = PokemonHeldItemMapper.ToDto(pokemonApiData.held_items);
            dto.Moves = PokemonMoveMapper.ToDto(pokemonApiData.moves);
            dto.Sprites = PokemonSpritesMapper.ToDto(pokemonApiData.sprites);
            dto.CryAudioSourceLegacy = pokemonApiData.cries.legacy;
            dto.CryAudioSourceLatest = pokemonApiData.cries.latest;
            dto.Types = PokemonTypeMapper.ToDto(pokemonApiData.types);
            dto.Past_types = PokemonTypePastMapper.ToDto(pokemonApiData.past_types);

            return dto;
        }

    }
}
