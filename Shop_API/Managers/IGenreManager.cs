using Shop_API.Entities;
using Shop_API.Models;

namespace Shop_API.Managers;

public interface IGenreManager
{
    Task<Genre> CreateGenre(CreateGenre genre);
}
