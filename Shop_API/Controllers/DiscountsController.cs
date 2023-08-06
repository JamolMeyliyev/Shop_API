using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Shop_API.Entities;
using Shop_API.Managers;

namespace Shop_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountManager _manager;
        public DiscountsController(IDiscountManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateDiscount discount)
        {
            try
            {
               var discountModel = await _manager.CreateDiscount(discount);
               return Created("",discountModel.Id);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    } 
}
