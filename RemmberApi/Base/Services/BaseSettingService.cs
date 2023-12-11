namespace RemmberApi;

public abstract class BaseSettingService<TEntity> : BaseService<TEntity>, IBaseSettingService<TEntity>
    where TEntity : BaseSettingEntity
{
    private readonly IBaseSettingRepository<TEntity> _baseSettingRepository;
    public BaseSettingService(IBaseSettingRepository<TEntity> repository, IValidator<TEntity> validator) : base(repository, validator)
        => _baseSettingRepository = repository;
}
