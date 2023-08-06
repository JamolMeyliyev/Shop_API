using Shop_API.Entities;
using Shop_API.Models;

namespace Shop_API.Managers;

public interface IPublisherManager
{
    Task<PublisherModel> CreatePushlisher(CreatePublisher publisher);
}