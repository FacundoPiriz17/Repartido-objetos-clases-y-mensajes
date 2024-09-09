namespace ArbolGenealogico;

public class Person
{
    private string name;
    private string role;
    private Person FirstProgenitor;
    private Person SecondProgenitor;

    public Person(string name, string role)
    {
        this.name = name;
        this.role = role;
    }
    public string Name
    {
        get { return name; }
        set { Name = name; }
    }

    public string Role
    {
        get { return role; }
        set { Role = role; }
    }
    
    
    
    

    public string GetName()
    {
        return Name;
    }

    public string ShowFamilyTree()
    {
        return $"Arbol genealogico de {Name}: {FirstProgenitor.Name} es su {FirstProgenitor.Role}. {SecondProgenitor.Name} es su {SecondProgenitor.Role}";
    }
}