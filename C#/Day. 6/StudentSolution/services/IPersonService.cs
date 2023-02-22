namespace StudentSolution.Services;

public interface IPersonService
{
    public uint Age { get; }
    public decimal Salary { get; set; }
    public List<string> Addresses { get; }
}