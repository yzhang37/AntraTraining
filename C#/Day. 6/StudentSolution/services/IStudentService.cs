namespace StudentSolution.Services;

public interface IStudentService: IPersonService
{
    public bool TakeCourse(ICourseService course);
    public bool DropCourse(ICourseService course);
    public List<ICourseService> Courses { get; }
    
    public double GPA { get; }
}