using Microsoft.AspNetCore.Mvc;

namespace Shop_API.Entities;

public class BookFilter
{
    [FromQuery(Name ="name")]
    public string? Name { get; set; }
    [FromQuery(Name = "author")]
    public string? Author { get; set; }
    [FromQuery(Name = "publisher")]
    public string? Publisher { get; set; }
    [FromQuery(Name = "fromprice")]
    public decimal? FromPrice { get; set; }
    [FromQuery(Name = "toprice")]
    public decimal? ToPrice { get; set;}
    [FromQuery(Name = "genre")]
    public string? Genre { get; set; }

}
