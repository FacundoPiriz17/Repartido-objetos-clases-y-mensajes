namespace Library.Tests;

public class TestsEjercicio2
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        //Ejercicio 2
        Smoothie smoothie1 = new Smoothie("batido de frutilla", 100);
        Ingredientes ingrediente1 = new Ingredientes("vainilla", 20);
        Ingredientes ingrediente2 = new Ingredientes("caramelo", 15);
        Ingredientes ingrediente3 = new Ingredientes("chantilli", 25);
        smoothie1.AddIngredients(ingrediente1);
        smoothie1.AddIngredients(ingrediente2);
        smoothie1.AddIngredients(ingrediente1);
        smoothie1.AddIngredients(ingrediente3);
        Console.WriteLine(smoothie1.GetFullName());
        Console.WriteLine($"Precio total: {smoothie1.GetTotalPrice()}");
    }
}