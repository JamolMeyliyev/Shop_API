using Shop_API.Entities;
using Shop_API.Models;

namespace Shop_API.Managers;

public interface IDiscountManager
{
    
    Task<Discount> CreateDiscount(CreateDiscount discount);
    
}
