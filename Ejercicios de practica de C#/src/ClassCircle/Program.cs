namespace ClassCircle;


public class Program
{
    public static void Main()
    {
        Circle circulo = new Circle(3.5);
        Console.WriteLine(circulo.GetArea());
        Console.WriteLine(circulo.GetPerimeter());

    }
}