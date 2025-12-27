using System;
using VideoGameCharacterApi.Dtos;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services;

public interface IVideoGameCharacterService
{
Task<List<GetCharacterResponseDto>> GetAllCharactersAsync();
Task<GetCharacterResponseDto?> GetCharacterByIdAsync(int id);
Task<GetCharacterResponseDto> AddCharacterAsync(CreateCharacterDto character);
Task<bool> UpdateCharacterAsync(int id, UpdateCharacterDto character);
Task<bool> DeleteCharacterAsync(int id);

}
