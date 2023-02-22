namespace StudentSolution.Services;

public interface IDepartmentService
{
    IInstructorService Head { get; }
    
}