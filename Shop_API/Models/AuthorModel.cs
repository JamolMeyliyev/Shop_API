using Shop_API.Entities;

namespace Shop_API.Models;

public record AuthorModel(int Id,string Name);


public static class AuthorExtension
{
    public static AuthorModel ToModel(this Author author)
    {
        return new AuthorModel(author.Id, author.Name);
    }
}



