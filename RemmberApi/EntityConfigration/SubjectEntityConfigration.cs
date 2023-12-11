namespace RemmberApi;

public class SubjectEntityConfiguration :BaseSettingEntityConfiguration<Subject>
{
    public override void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.ToTable("Subjects");

        base.Configure(builder);
    }
}
