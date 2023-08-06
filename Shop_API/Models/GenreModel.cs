using Shop_API.Entities;

namespace Shop_API.Models;

public record GenreModel(int Id,string Name);
public static class GenreExtension
{
    public static GenreModel ToModel(this Genre entity)
    {
        return new GenreModel(entity.Id, entity.Name);
    }
}
