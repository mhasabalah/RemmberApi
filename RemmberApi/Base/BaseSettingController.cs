namespace RemmberApi;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseSettingController<TEntity> : BaseController<TEntity>
    where TEntity : BaseSettingEntity
{
    public BaseSettingController(IBaseSettingService<TEntity> service) : base(service) { }

}
