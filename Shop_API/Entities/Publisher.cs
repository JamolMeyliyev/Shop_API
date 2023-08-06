using System.Text.Json.Serialization;

namespace Shop_API.Entities;

public class Publisher:Entity
{

    public List<Book>? Books { get; set; }
    public List<Discount>? Discounts { get; set; }

    
}

public class CreatePublisher
{
 
    public required string Name { get; set; }

}
