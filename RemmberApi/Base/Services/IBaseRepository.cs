namespace RemmberApi;

public interface IBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task Add(TEntity entity);
    Task Add(IEnumerable<TEntity> entities);

    Task<TEntity> Get(int id);
    Task<IEnumerable<TEntity>> Get();

    Task<TEntity> Update(int id);
    Task<TEntity> Update(TEntity entity);

    Task<TEntity> Remove(int id);
    Task<TEntity> Remove(TEntity entity);
    Task<IDbContextTransaction> GetTransaction();
}