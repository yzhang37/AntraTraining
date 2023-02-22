namespace StudentSolution.Services;

public interface IInstructorService: IPersonService
{
    public IDepartmentService Department { get; set; }
    public DateTime JoinDate { get; set; }

    ICourseService OpenCourse(string courseName, string courseAlias, DateTime startDate, DateTime endDate);
}