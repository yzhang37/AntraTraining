namespace StudentSolution.Services;

public interface ICourseService
{
    List<IStudentService> GetEnrolledStudents();
    
    bool EnrollStudent(IStudentService student);
    
    bool DropStudent(IStudentService student);
    
    bool hasStudent(IStudentService student);
    
    IInstructorService GetInstructor();
    
    String CourseName { get; set; }
    
    String CourseAlias { get; set; }
    
    DateTime StartDate { get; }
    
    DateTime EndDate { get; }
}