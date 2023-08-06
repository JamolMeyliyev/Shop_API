using System.Text.Json.Serialization;

namespace Shop_API.Entities;

public class Book:Entity
{
   
    public int AuthorId { get; set; }
    [JsonIgnore]
    public Author? Author { get; set; }
    
    public int PublisherId { get; set; }
    [JsonIgnore]
    public Publisher? Publisher { get; set; }

    public int GenreId { get; set; }
    [JsonIgnore]
    public Genre? Genre { get; set; }
    public long Year { get; set; }
    public decimal Price { get; set; }

    
}


public class CreateBook
{

    public required string Name { get; set; }
    public int AuthorId { get; set; }
   

    public int PublisherId { get; set; }
    

    public int GenreId { get; set; }

    public long Year { get; set; }
    public decimal Price { get; set; }


}
