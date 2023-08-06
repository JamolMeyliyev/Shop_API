using Shop_API.Entities;

namespace Shop_API.Models;

public record DisModel(int Id, string Name);


public static class Extension
{
    public static PublisherModel ToModel(this Publisher entity)
    {
        return new PublisherModel(entity.Id, entity.Name);
    }
}
