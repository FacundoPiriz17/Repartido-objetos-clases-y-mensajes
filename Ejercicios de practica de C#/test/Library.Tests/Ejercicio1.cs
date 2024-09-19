namespace Library.Tests;

public class TestsEjercicio1
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        //Ejercicio 1
        Circulo circulo = new Circulo(5);
        Console.WriteLine($"El perimetro del circulo es: {circulo.GetPerimeter()}");
        Console.WriteLine($"El area del circulo es: {circulo.GetArea()}");
        
    }
}