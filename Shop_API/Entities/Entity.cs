namespace Shop_API.Entities;

public class Entity <TId>
{ 
    public TId Id { get; set; }
    public required string Name { get; set; }
}
public class Entity: Entity<int>
{

}
