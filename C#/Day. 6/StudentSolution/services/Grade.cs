namespace StudentSolution.Services;

public enum Grade
{
    A,
    B,
    C,
    D,
    F
}

// Helper to convert from Double points to Alphabetical Grade
public static class GradeHelper
{
    public static Grade GetGrade(double points)
    {
        if (points >= 90)
        {
            return Grade.A;
        }
        else if (points >= 80)
        {
            return Grade.B;
        }
        else if (points >= 70)
        {
            return Grade.C;
        }
        else if (points >= 60)
        {
            return Grade.D;
        }
        else
        {
            return Grade.F;
        }
    }
    
    public static double GetPoints(Grade grade)
    {
        switch (grade)
        {
            case Grade.A:
                return 4.0;
            case Grade.B:
                return 3.0;
            case Grade.C:
                return 2.0;
            case Grade.D:
                return 1.0;
            case Grade.F:
                return 0.0;
            default:
                return 0.0;
        }
    }
}