using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shop_API.Entities;
using System.Runtime.CompilerServices;

namespace Shop_API.Models;

public record Model (int Id,string Name);

public Model ToModel(this Entity entity)
{
    return new Model(entity.Id, entity.Name);
}

