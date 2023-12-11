namespace RemmberApi;

public class SubjectRepository : BaseSettingRepository<Subject>, ISubjectRepository
{
    public SubjectRepository(ApplicationDbContext context) : base(context)
    {
    }
}
