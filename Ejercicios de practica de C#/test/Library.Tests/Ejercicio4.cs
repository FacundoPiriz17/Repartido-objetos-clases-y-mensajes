namespace Library.Tests;

public class TestsEjercicio4
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        //Ejercicio 4
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
    }
}