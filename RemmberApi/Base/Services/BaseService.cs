namespace RemmberApi;

public abstract class BaseService<TEntity> :IBaseService<TEntity>
    where TEntity : BaseEntity
{
    private readonly IBaseRepository<TEntity> _repository;
    private readonly IValidator<TEntity> _validator;

    public BaseService(IBaseRepository<TEntity> repository, IValidator<TEntity> validator)
    {
        _repository = repository;
        _validator = validator;
    }

    public virtual async Task<TEntity> Create(TEntity entity)
    {
        using IDbContextTransaction transaction = await _repository.GetTransaction();
        try
        {
            await _repository.Add(entity);
            await transaction.CommitAsync();
            return entity;
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();

            throw;
        }
    }

    public virtual async Task<TEntity> Read(int id) => await _repository.Get(id);
    public virtual async Task<IEnumerable<TEntity>> Read() => await _repository.Get();
}
