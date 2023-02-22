namespace ColorSolution;

public class Color
{
    public Color(byte red, byte green, byte blue, byte alpha)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public Color(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = 255;
    }
    
    public byte Red { get; set; }

    public byte Green { get; set; }

    public byte Blue { get; set; }
    
    public byte Alpha { get; set; }
    
    // get the grayscale value of the color
    public byte Grayscale
    {
        get
        {
            return (byte) (0.2126 * Red + 0.7152 * Green + 0.0722 * Blue);
        }
    }
    
    public override string ToString()
    {
        return $"Color: R={Red}, G={Green}, B={Blue}, A={Alpha}";
    }
}