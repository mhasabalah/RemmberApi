namespace RemmberApi;

public interface IBaseService<TEntity>
    where TEntity : BaseEntity
{
    Task<TEntity> Create(TEntity entity);

    Task<TEntity> Read(int id);
    Task<IEnumerable<TEntity>> Read();
}