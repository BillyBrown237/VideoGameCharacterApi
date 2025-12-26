using Microsoft.EntityFrameworkCore;
using System;
using VideoGameCharacterApi.Data;
using VideoGameCharacterApi.Dtos;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services;

public class VideoGameCharacterService(AppDbContext context) : IVideoGameCharacterService
{
  
    public Task<GetCharacterResponseDto> AddCharacterAsync(Character character)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCharacterAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<GetCharacterResponseDto>> GetAllCharactersAsync()
    {
        return await context.Characters.Select(c => new GetCharacterResponseDto { Name = c.Name, Game = c.Game, Role = c.Role}).ToListAsync();
    }

    public async Task<GetCharacterResponseDto?> GetCharacterByIdAsync(int id)
    { 
        var result = await context.Characters.Where(c => c.Id == id).Select(c => new GetCharacterResponseDto { Name = c.Name, Game = c.Game, Role = c.Role }).FirstOrDefaultAsync();
       
        return result;
    }

    public Task<bool> UpdateCharacterAsync(int id, Character character)
    {
        throw new NotImplementedException();
    }
}
