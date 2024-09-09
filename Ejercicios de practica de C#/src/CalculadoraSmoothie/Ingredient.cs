namespace CalculadoraSmoothie;

public class Ingredient
{
    private string name;
    private double cost;

    public Ingredient(string name, double cost)
    {
        this.name = name;
        this.cost = cost;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Cost
    {
        get { return cost; }
        set { cost = value; }
    }
}