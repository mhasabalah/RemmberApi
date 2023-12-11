namespace RemmberApi.Shared;

public class Classroom : BaseSettingEntity
{
    public int SubjectId { get; set; }
    public Subject? Subject { get; set; }
    
    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }

    public List<ClassRoomStudent>? ClassRoomStudents { get; set; }
}

public class ClassRoomStudent : BaseEntity
{
    public int ClassRoomId { get; set; }
    public int StudentId { get; set; }
    public Student? Student { get; set; }
}