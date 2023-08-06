using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_API.Entities;
using Shop_API.Managers;

namespace Shop_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenresController : ControllerBase
{
    private readonly IGenreManager _manager;
    public GenresController(IGenreManager manager)
    {
        _manager = manager;
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateGenre genre)
    {
        try
        {
          var genreModel =  await _manager.CreateGenre(genre);
            return Created("", genreModel.Id);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

