using System.Text;
using Library;

public class Smoothie
{
    public string NombreSmoothie;
    public double PrecioBase;
    /*public double precioBase
    {get {return PrecioBase;} }*/
    public List<Ingredientes> IngredientesExtra = new List<Ingredientes> {};

    public Smoothie(string NombreSmoothie, double PrecioBase)
    {
        this.NombreSmoothie = NombreSmoothie;
        this.PrecioBase = PrecioBase;
    }

    public void AddIngredients(Ingredientes ingrediente)
    {
        foreach (var elem in this.IngredientesExtra)
        {
            if(elem.NombreIngrediente == ingrediente.NombreIngrediente)
            {
                Console.WriteLine("Ese ingrediente ya ah sido agregado al smoothie");
                return;
            }
        }
        this.IngredientesExtra.Add(ingrediente);
        return;
    }

    public double GetTotalPrice()
    {
        double PrecioTotal = PrecioBase;
        foreach (var elem in IngredientesExtra)
        {
            PrecioTotal = PrecioTotal + elem.CostoIngrediente;
        }
        return PrecioTotal;
    }

    public string GetFullName()
    {
        string fullName = this.NombreSmoothie + " con ";
        foreach (var item in this.IngredientesExtra)
        {
            fullName = fullName + $"{item.NombreIngrediente}, ";
        }
        return fullName;
    }

}