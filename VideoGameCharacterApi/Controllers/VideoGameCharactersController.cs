using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterApi.Dtos;
using VideoGameCharacterApi.Models;
using VideoGameCharacterApi.Services;

namespace VideoGameCharacterApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class VideoGameCharactersController(IVideoGameCharacterService service) : ControllerBase
{    
    [HttpGet]
    public async Task<ActionResult<List<GetCharacterResponseDto>>> GetCharacters()
    {
      return Ok(await service.GetAllCharactersAsync());
        
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<GetCharacterResponseDto>> GetCharacter(int id)
    {
        var character = await service.GetCharacterByIdAsync(id);
        if (character is null)
        {
            return NotFound("Character with the given Id was not found");
        }
        return Ok(character);
    }
    [HttpPost]
   public async Task<ActionResult<GetCharacterResponseDto>> AddCharacter([FromBody] CreateCharacterDto character)
    {
        var createdCharacter = await service.AddCharacterAsync(character);
        return CreatedAtAction(nameof(GetCharacter), new { id = createdCharacter.Id }, createdCharacter);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateCharacter(int id, [FromBody] UpdateCharacterDto character)
    {
        var isUpdated = await service.UpdateCharacterAsync(id, character);
        if (!isUpdated)
        {
            return NotFound("Character with the given Id was not found");
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCharacter(int id)
    {
        var isDeleted = await service.DeleteCharacterAsync(id);
        if (!isDeleted)
        {
            return NotFound("Character with the given Id was not found");
        }
        return NoContent();
    }
}