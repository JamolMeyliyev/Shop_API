namespace Shop_API.Managers;


public interface IManager<TEntity,TModel>
{
    Task<TModel> Create(TEntity entity);
}
    
