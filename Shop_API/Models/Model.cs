
using Shop_API.Entities;


namespace Shop_API.Models;

public record Model (int Id,string Name);
public static class ExtensionEntity
{
    public static Model ToModel(this Entity entity)
    {
        return new Model(entity.Id, entity.Name);
    }

}

