using StudentSolution.Services;

namespace StudentSolution.controllers;

public class Instructor: Person, IInstructorService
{
    public IDepartmentService Department { get; set; }
    public DateTime JoinDate { get; set; }
    
    public ICourseService OpenCourse(string courseName, string courseAlias, DateTime startDate, DateTime endDate)
    {
        return new Course(courseName, courseAlias, this, startDate, endDate);
    }

    public Instructor(Department department,
        DateTime joinDate,
        DateTime birthDate,
        List<string>? addresses = null,
        decimal salary = 0): base(birthDate, addresses, salary)
    {
        this.Department = department;
        this.JoinDate = joinDate;
    }
}