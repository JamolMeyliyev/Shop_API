using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop_API.Entities;
using Shop_API.Managers;

namespace Shop_API.Controllers;


[Route("api/[controller]")]
[ApiController]
public class PublishersController : ControllerBase
{

    private readonly IPublisherManager _manager;
    public PublishersController(IPublisherManager manager)
    {
        _manager = manager;
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreatePublisher publisher)
    {
        try
        {
          var  publisherModel =  await _manager.CreatePushlisher(publisher);
            return Created("", publisherModel.Id);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

