namespace Library;

public class Bank
{
    List<Account> accounts;

    public Bank()
    {
        this.accounts = new List<Account> {};
    }

    public void AddAccountToBank(Account account)
    {
        this.accounts.Add(account);
    }
}