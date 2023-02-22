using StudentSolution.Services;

namespace StudentSolution.controllers;

public class Person : IPersonService
{
    private decimal _salary;

    public decimal Salary
    {
        get => _salary;
        set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative");
            this._salary = value;
        }
    }

    public List<string> Addresses { get; }

    private readonly DateTime _birthDate;

    public DateTime BirthDate
    {
        get => _birthDate;
    }

    public uint Age
    {
        get
        {
            var today = DateTime.Today;
            var age = today.Year - _birthDate.Year;
            if (_birthDate.Date > today.AddYears(-age))
                age--;
            return (uint)age;
        }
    }

    public Person(DateTime birthDate, List<string>? addresses = null, decimal salary = 0)
    {
        _birthDate = birthDate;
        Addresses = addresses ?? new List<string>();
        Salary = salary;
    }
}