using Microsoft.EntityFrameworkCore.Metadata;
using Shop_API.Context;
using Shop_API.Entities;
using Shop_API.Models;

namespace Shop_API.Managers;

public class AuthorManager :IManager<Author,AuthorModel>
{
    private readonly ShopDbContext _context;
    public AuthorManager(ShopDbContext context)
    {
        _context = context;
    }

    

    public async  Task<AuthorModel> Create(Author entity)
    {
        var model = new Author()
        {
            Name = entity.Name,
            Books = new List<Book>(),
            Discounts = new List<Discount>()
        };

        _context.Authors.Add(model);

        await _context.SaveChangesAsync();
        return model;
    }
}
