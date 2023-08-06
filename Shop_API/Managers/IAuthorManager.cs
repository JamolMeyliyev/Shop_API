using Shop_API.Entities;
using Shop_API.Models;

namespace Shop_API.Managers;

public interface IAuthorManager
{
    Task<Author> CreateAuthor(CreateAuthor author);

}
