using Shop_API.Entities;

namespace Shop_API.Models;

public record DiscountModel(int Id, string Name);


public static class Extension
{
    public static DiscountModel ToModel(this Discount entity)
    {
        return new DiscountModel(entity.Id, entity.Name);
    }
}
