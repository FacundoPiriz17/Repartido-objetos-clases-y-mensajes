namespace Library.Tests;

public class TestsEjercicio3
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        //Ejercicio 3
        Person person1 = new Person("juan","hijo");
        Person person2 = new Person("pedro","padre");
        Person person3 = new Person("clara","madre");
        Person person4 = new Person("carlos","abuelo");
        Person person5 = new Person("maria","abuela");
        person1.AddFirstProgenitor(person2);
        person1.AddFirstProgenitor(person3);
        person1.AddSecondProgenitor(person4);
        person1.AddSecondProgenitor(person5);
        Console.WriteLine(person1.ShowFamilyTree());
    }
}