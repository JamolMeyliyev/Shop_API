using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_API.Entities;
using Shop_API.Managers;

namespace Shop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookManager _manager;
        public BooksController(IBookManager manager)
        {
            _manager = manager;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateBook book)
        {
            try
            {
               var bookModel = await _manager.CreateBook(book);
                return Created("id:", bookModel.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetBooks([FromQuery] BookFilter filter)
        {
            try
            {
              return  Ok( await _manager.GetBooks(filter));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
