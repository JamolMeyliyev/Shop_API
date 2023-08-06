namespace Shop_API.Entities;

public class Genre:Entity
{
    

    public List<Book>? Books { get; set; }   
    
}
public class CreateGenre
{
   
    public required string Name { get; set; }

    

}
