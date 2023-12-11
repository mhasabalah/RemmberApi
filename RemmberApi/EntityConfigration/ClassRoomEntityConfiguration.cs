namespace RemmberApi;

public class ClassRoomEntityConfiguration : BaseSettingEntityConfiguration<Classroom>
{
    public override void Configure(EntityTypeBuilder<Classroom> builder)
    {
        builder.ToTable("ClassRooms");

        builder.Property(e => e.SubjectId).IsRequired();
        builder.HasOne(e => e.Subject).WithMany().HasForeignKey(e => e.SubjectId).OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.TeacherId).IsRequired();
        builder.HasOne(e => e.Teacher).WithMany().HasForeignKey(e => e.TeacherId).OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.ClassRoomStudents).WithOne().HasForeignKey(e => e.ClassRoomId)
            .OnDelete(DeleteBehavior.Cascade);

        base.Configure(builder);
    }
}
