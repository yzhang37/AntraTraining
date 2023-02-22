namespace ColorSolution;

public class Ball
{
    private double _radius;
    private uint _throwCount;

    public double Radius
    {
        get
        {
            return _radius;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"Radius cannot be negative");
            }
            _radius = value;
        }
    }
    
    public Color Color { get; set;  }
    
    public Ball(double radius, Color? color = null)
    {
        _throwCount = 0;
        Radius = radius;
        color ??= new Color(255, 0, 0);
        Color = color;
    }

    public void Pop()
    {
        this.Radius = 0;
    }

    public bool Throw()
    {
        if (this.Radius > 0)
        {
            this._throwCount += 1;
            return true;
        }

        return false;
    }

    public uint ThrowCount => this._throwCount;
}