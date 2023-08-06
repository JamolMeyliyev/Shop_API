using Shop_API.Entities;

namespace Shop_API.Models;

public record BookModel(

    string Name,
    int AuthorId,
    int PublisherId,
    long Year,
    decimal Price

    );


public static class BookExtension
{
    public static BookModel ToModel(this Book entity)
    {
        return new BookModel(entity.Name,entity.AuthorId,entity.PublisherId,entity.Year,entity.Price);
    }
}