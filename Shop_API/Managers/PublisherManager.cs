using Shop_API.Context;
using Shop_API.Entities;
using Shop_API.Models;

namespace Shop_API.Managers;

public class PublisherManager : IPublisherManager
{
    private readonly ShopDbContext _context;
    public PublisherManager(ShopDbContext context)
    {
        _context = context;
    }
    public async Task<Publisher> CreatePushlisher(CreatePublisher model)
    {
        var publisher =  new Publisher() {
            Name= model.Name,
            Books = new List<Book>(),
            Discounts= new List<Discount>()
        };

        _context.Publisher.Add(publisher);
        await _context.SaveChangesAsync();
        return publisher;
    }
}
