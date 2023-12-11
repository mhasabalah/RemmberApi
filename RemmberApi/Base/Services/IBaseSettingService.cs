namespace RemmberApi;

public interface IBaseSettingService<TEntity> :IBaseService<TEntity> 
    where TEntity : BaseSettingEntity
{
}
