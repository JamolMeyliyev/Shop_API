
using Microsoft.AspNetCore.Mvc;
using Shop_API.Entities;
using Shop_API.Managers;


namespace Shop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorManager _manager;
        public AuthorsController(IAuthorManager manager)
        {
            _manager = manager;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAuthor author)
        {
            try
            {
               var authorModel= await _manager.CreateAuthor(author);
                return Created("",new { id = authorModel.Id });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
