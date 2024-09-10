using Library;

public class Account
{
    private int Number;
    private double Balance;
    Person Titular;

    public Account(int Number, Person person)
    {
        if (Number > 0)
        {
        this.Number = Number;
        this.Balance = 0;
        this.Titular = person;
        }
        else
        {Console.WriteLine("numero no valido");}
    }

    public void AddToBalancce(double Amount)
    {
        this.Balance = this.Balance + Amount;
        Console.WriteLine($"Se han añadido {Amount} pesos a la cuenta. Saldo total: {this.Balance}");
    }

    public void RemoveFromBalancce(double Amount)
    {
        if (this.Balance - Amount >= 0)
        {
            this.Balance = this.Balance - Amount;
            Console.WriteLine($"Se han debitado {Amount} pesos de la cuenta. Saldo total: {this.Balance}");
        }
        else
        {Console.WriteLine($"No tienes saldo suficiente para debitar {this.Balance}");}
    }

    public void TransferTo(Account account, double Amount)
    {
        if (this.Balance - Amount >= 0)
        {
            this.Balance = this.Balance - Amount;
            Console.WriteLine($"Se han transferido {Amount} pesos a la cuenta de {account.Titular.Name}. Saldo total: {this.Balance}");
        }
        else
        {Console.WriteLine($"No tienes saldo suficiente para debitar ${this.Balance} a {account.Titular.Name}");}
    }
}