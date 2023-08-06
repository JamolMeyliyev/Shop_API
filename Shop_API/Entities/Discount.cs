using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shop_API.Entities;

public class Discount
{
    [Key]
    public int Id { get; set; }
    public int? BookId { get; set; }
    [JsonIgnore]
    public Book? Book { get; set; }
    public int? AuthorId { get; set; }
    [JsonIgnore]
    public Author? Author { get; set; }
    public int? PublisherId { get; set; }
    [JsonIgnore]
    public Publisher? Publisher { get; set; }
    public int Percentage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class CreateDiscount
{

    
    public int? BookId { get; set; }
    
    public int? AuthorId { get; set; }
 
    public int? PublisherId { get; set; }
 
    public int Percentage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}