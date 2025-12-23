using System;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services;

public class VideoGameCharacterService : IVideoGameCharacterService
{
      static readonly List<Character> characters =
    [
        new() { Id = 1, Name = "Mario", Game = "Super Mario Bros", Role = "Hero" },
        new() { Id = 2, Name = "Link", Game = "The Legend of Zelda", Role = "Protagonist" },
        new() { Id = 3, Name = "Bowser", Game = "Super Mario Bros", Role = "Villain" },
        new() { Id = 4, Name = "Zelda", Game = "The legends of Zelda", Role = "Princess" }
    ];
    public Task<Character> AddCharacterAsync(Character character)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCharacterAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Character>> GetAllCharactersAsync()
    {
         return await Task.FromResult(characters);
    }

    public async Task<Character?> GetCharacterByIdAsync(int id)
    {
        var result = characters.FirstOrDefault(c => c.Id == id);
        return await Task.FromResult(result);
    }

    public Task<bool> UpdateCharacterAsync(int id, Character character)
    {
        throw new NotImplementedException();
    }
}
