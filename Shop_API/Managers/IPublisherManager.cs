using Shop_API.Entities;
using Shop_API.Models;

namespace Shop_API.Managers;

public interface IPublisherManager
{
    Task<Publisher> CreatePushlisher(CreatePublisher publisher);
}
