using Microsoft.EntityFrameworkCore;
using Shop_API.Context;
using Shop_API.Entities;

namespace Shop_API.Managers;

public class BookManager : IBookManager
{
    private readonly ShopDbContext _context;
public BookManager(ShopDbContext context)
{
    _context = context;
}

    public async Task<Book> CreateBook(CreateBook model)
    {
        var book = new Book()
        {
            Name = model.Name,
            AuthorId = model.AuthorId,
            GenreId = model.GenreId,
            PublisherId = model.PublisherId,
            Year = model.Year,
            Price = model.Price


};
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
        return book;
        
    }

    public async Task<List<Book>> GetBooks(BookFilter filter)
    {
        var query = _context.Books.AsQueryable();
        if (filter.Name is not null)
        {
            query = query.Where(c => c.Name.Contains(filter.Name));
        }
        if (filter.Author is not null)
        {
            query = query.Where(c => c.Name.Contains(filter.Author));
        }
        if (filter.Publisher is not null)
        {
            query = query.Where(c => c.Name.Contains(filter.Publisher));
        }
        if (filter.FromPrice is not null)
        {
            query = query.Where(c => c.Price >= filter.FromPrice);
        }
        if (filter.ToPrice is not null)
        {
            query = query.Where(c => c.Price <= filter.ToPrice);
        }

        return await query.ToListAsync();
    }
 }





