namespace RemmberApi;

public class SubjectService : BaseSettingService<Subject>, ISubjectService
{
    public SubjectService(ISubjectRepository repository, IValidator<Subject> validator) : base(repository, validator)
    {
    }
}
