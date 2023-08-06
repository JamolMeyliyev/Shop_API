using System.Text.Json.Serialization;

namespace Shop_API.Entities;

public class Author:Entity
{
    public List<Book>? Books { get; set; }
    public List<Discount>? Discounts { get; set; }
}
public class CreateAuthor
{
    public required string Name { get; set; }
}

