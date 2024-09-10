using Library;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        /*Ejercicio 1
        Circulo circulo = new Circulo(5);
        Console.WriteLine($"El perimetro del circulo es: {circulo.GetPerimeter()}");
        Console.WriteLine($"El area del circulo es: {circulo.GetArea()}");
        */

        /*Ejercicio 2
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
        */

        /*Ejercicio 3
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
        */

        /*Ejercicio 4
        Person person1 = new Person("juan","hijo");
        Person person2 = new Person("pedro","padre");
        Account account1 = new Account(0001,person1);
        Account account2 = new Account(0002,person2);
        Bank bank= new Bank();
        bank.AddAccountToBank(account1);
        bank.AddAccountToBank(account2);
        account1.AddToBalancce(1000);
        account1.RemoveFromBalancce(400);
        account1.RemoveFromBalancce(1000);
        account1.TransferTo(account2, 200);
        */

        //Ejercicio 5
        

    }
}
