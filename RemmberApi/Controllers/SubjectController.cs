namespace RemmberApi;

[ApiController]
[Route("api/[controller]")]
public class SubjectController : BaseSettingController<Subject>
{
    public SubjectController(ISubjectService service) : base(service)
    {
    }
}
