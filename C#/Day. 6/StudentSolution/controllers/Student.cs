using StudentSolution.Services;

namespace StudentSolution.controllers;

public class Student: Person, IStudentService
{
    public bool TakeCourse(ICourseService course)
    {
        return course.EnrollStudent(this);
    }

    public bool DropCourse(ICourseService course)
    {
        return course.DropStudent(this);
    }

    public List<ICourseService> Courses { get; }
    public double GPA { get; }

    public Student(DateTime birthDate,
        List<string>? addresses = null,
        decimal salary = 0): base(birthDate, addresses, salary)
    {
        this.Courses = new List<ICourseService>();
    }
}