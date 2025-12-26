using System;
using VideoGameCharacterApi.Dtos;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services;

public interface IVideoGameCharacterService
{
Task<List<GetCharacterResponseDto>> GetAllCharactersAsync();
Task<GetCharacterResponseDto?> GetCharacterByIdAsync(int id);
Task<GetCharacterResponseDto> AddCharacterAsync(Character character);
Task<bool> UpdateCharacterAsync(int id, Character character);
Task<bool> DeleteCharacterAsync(int id);

}
