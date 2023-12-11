namespace RemmberApi;

public class BaseSettingEntityConfiguration<TEntity> : BaseEntityConfiguration<TEntity>, IEntityTypeConfiguration<TEntity>
    where TEntity : BaseSettingEntity
{
    public new virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        base.Configure(builder);
        builder.HasIndex(e => e.Name).IsUnique();

        builder.Property(e => e.Name).IsRequired();
        builder.Property(e => e.Name).HasMaxLength(50);
    }
}
