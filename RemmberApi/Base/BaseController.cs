namespace RemmberApi;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseController<TEntity> : ControllerBase
    where TEntity : BaseEntity
{
    private readonly IBaseService<TEntity> _baseService;
    public BaseController(IBaseService<TEntity> service) => _baseService = service;

    [HttpGet]
    public virtual async Task<IEnumerable<TEntity>> Get() => await _baseService.Read();

    [HttpGet("{id}")]
    public virtual async Task<TEntity> Get(int id) => await _baseService.Read(id); 
  
    [HttpPost]
    public virtual async Task<TEntity> Post(TEntity entity) => await _baseService.Create(entity);
}
