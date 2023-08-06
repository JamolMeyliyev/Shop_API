using Shop_API.Context;
using Shop_API.Entities;

namespace Shop_API.Managers;

public class DiscountManager : IDiscountManager
{
    private readonly ShopDbContext _context;
    public DiscountManager(ShopDbContext context)
    {
        _context = context;
    }
    public async Task<Discount> CreateDiscount(CreateDiscount model)
    {
        var disCount = new Discount()
        {
     
     BookId = model.BookId,

    AuthorId = model.AuthorId,


   PublisherId = model.PublisherId,

     Percentage  =model.Percentage,
    StartDate = model.StartDate,
     EndDate = model.EndDate
};
        _context.Discounts.Add(disCount);
        await _context.SaveChangesAsync();
        return disCount;
    }
}
