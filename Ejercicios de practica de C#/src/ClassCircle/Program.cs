namespace ClassCircle;

public class Circle
{
    private double Radius;
    
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetPerimeter()
    {
        return Radius * 2 * 3.1416;
    }

    public double GetArea()
    {
        return Radius * Radius * 3.1416;
    }
}

public class Program
{
    public static void Main()
    {


    }
}