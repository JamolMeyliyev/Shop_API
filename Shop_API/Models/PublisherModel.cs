using Shop_API.Entities;

namespace Shop_API.Models;

public record PublisherModel(int Id, string Name);


public static class PublisherExtension
{
    public static PublisherModel ToModel(this Publisher entity)
    {
        return new PublisherModel(entity.Id, entity.Name);
    }
}