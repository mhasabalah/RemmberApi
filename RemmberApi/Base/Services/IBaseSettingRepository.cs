namespace RemmberApi;

public interface IBaseSettingRepository<TEntity> : IBaseRepository<TEntity> 
    where TEntity : BaseSettingEntity
{
    Task<IEnumerable<TEntity>> Search(string searchText);
}
