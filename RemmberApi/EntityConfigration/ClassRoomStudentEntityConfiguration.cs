namespace RemmberApi;

public class ClassRoomStudentEntityConfiguration : BaseEntityConfiguration<ClassRoomStudent>
{
    public override void Configure(EntityTypeBuilder<ClassRoomStudent> builder)
    {
        builder.ToTable("ClassRoomStudents");

        builder.HasIndex(e => new { e.ClassRoomId, e.StudentId }).IsUnique();

        builder.Property(e => e.StudentId).IsRequired();

        builder.HasOne(e => e.Student).WithMany().HasForeignKey(e => e.StudentId)
               .OnDelete(DeleteBehavior.Restrict);

        base.Configure(builder);
    }
}
