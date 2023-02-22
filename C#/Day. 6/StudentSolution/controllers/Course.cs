using StudentSolution.Services;

namespace StudentSolution.controllers;

public class Course: ICourseService
{
    public List<IStudentService> GetEnrolledStudents()
    {
        throw new NotImplementedException("this function need SQL backend, skip");
    }

    public bool EnrollStudent(IStudentService student)
    {
        throw new NotImplementedException("this function need SQL backend, skip");
    }

    public bool DropStudent(IStudentService student)
    {
        throw new NotImplementedException("this function need SQL backend, skip");
    }

    public bool hasStudent(IStudentService student)
    {
        throw new NotImplementedException("this function need SQL backend, skip");
    }

    public IInstructorService GetInstructor()
    {
        return _instructor;
    }

    public string CourseName { get; set; }
    public string CourseAlias { get; set; }
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }

    private Instructor _instructor;
    
    public Course(string courseName,
        string courseAlias,
        Instructor instructor,
        DateTime startDate,
        DateTime endDate)
    {
        this.CourseName = courseName;
        this.CourseAlias = courseAlias;
        this.StartDate = startDate;
        this.EndDate = endDate;
        this._instructor = instructor;
    }
}