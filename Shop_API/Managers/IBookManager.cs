using Shop_API.Entities;
using Shop_API.Models;

namespace Shop_API.Managers;

public interface IBookManager
{
    Task<List<Book>> GetBooks(BookFilter filter);
    Task<Book> CreateBook(CreateBook book);
}
