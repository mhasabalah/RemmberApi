namespace RemmberApi;

public class BaseRepository<TEntity> :IBaseRepository<TEntity>
    where TEntity : BaseEntity
{
    private readonly ApplicationDbContext _context;
    protected DbSet<TEntity> dbSet;
    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
        dbSet = _context.Set<TEntity>();
    }

    public virtual async Task<IEnumerable<TEntity>> Get() => await dbSet.ToListAsync();
    public virtual async Task<TEntity> Get(int id) =>
        await dbSet.FirstOrDefaultAsync(e => e.Id == id) ?? Activator.CreateInstance<TEntity>();

    public virtual async Task Add(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await dbSet.AddAsync(entity);
        await SaveChangesAsync();
    }

    public virtual async Task Add(IEnumerable<TEntity> entities)
    {
        ArgumentNullException.ThrowIfNull(entities);

        await dbSet.AddRangeAsync(entities);
        await SaveChangesAsync();
    }

    public virtual async Task<TEntity> Update(TEntity entity)
    {
        TEntity entityFromDb = await Get(entity.Id);
        ArgumentNullException.ThrowIfNull(entityFromDb);

        dbSet.Update(entity);
        await SaveChangesAsync();

        return entity;
    }

    public virtual async Task<TEntity> Update(int id)
    {
        TEntity entityFromDb = await Get(id);
        ArgumentNullException.ThrowIfNull(entityFromDb);

        dbSet.Update(entityFromDb);
        await SaveChangesAsync();

        return entityFromDb;
    }

    public virtual async Task<TEntity> Remove(TEntity entity)
    {
        await Task.Run(() => dbSet.Remove(entity));
        await SaveChangesAsync();

        return entity;
    }

    public virtual async Task<TEntity> Remove(int id)
    {
        TEntity entityFromDb = await Get(id);
        ArgumentNullException.ThrowIfNull(entityFromDb);

        return await Remove(entityFromDb);
    }
    public async Task<IDbContextTransaction> GetTransaction() => await _context.Database.BeginTransactionAsync();
    protected async Task SaveChangesAsync() => await _context.SaveChangesAsync();

    public void Dispose() => _context.Dispose();
}