﻿using Shop_API.Context;
using Shop_API.Entities;

namespace Shop_API.Managers;

public class GenreManager:IGenreManager
{
    private readonly ShopDbContext _context;
    public GenreManager(ShopDbContext context)
    {
        _context = context;
    }
    public async Task<Genre> CreateGenre(CreateGenre model)
    {
        var genre = new Genre()
        {
            Name = model.Name,
            Books = new List<Book>()
        };
        _context.Genres.Add(genre);
        await _context.SaveChangesAsync();
        return genre;
    }
}
