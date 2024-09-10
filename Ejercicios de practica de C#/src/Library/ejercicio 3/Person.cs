namespace Library;

public class Person
{
    public string Name;
    public string Role;
    List<Person> FirstProgenitor = new List<Person> {};
    List<Person> SecondProgenitor = new List<Person> {};

    public Person(string name, string role)
    {
        this.Name = name;
        this.Role = role;
    }

    public string GetName()
    {
        return this.Name;
    }

    public void AddFirstProgenitor(Person person)
    {
        this.FirstProgenitor.Add(person);
    }

        public void AddSecondProgenitor(Person person)
    {
        this.SecondProgenitor.Add(person);
    }

    public string ShowFamilyTree()
    {
        string str = $"{this.Name} es {this.Role}.";

        foreach (var elem in this.FirstProgenitor)
        {
            str = str + $" {elem.Name} es {elem.Role}.";
        }

        foreach (var elem in this.SecondProgenitor)
        {
            str = str + $" {elem.Name} es {elem.Role}.";
        }

        return str;
    }
}