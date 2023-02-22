using StudentSolution.Services;

namespace StudentSolution.controllers;

public class Department: IDepartmentService
{
    private Instructor _head;
    
    public IInstructorService Head
    {
        get => _head;
    }
    
    public Department(Instructor head)
    {
        this._head = head;
    }
}