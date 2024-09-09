namespace CalculadoraSmoothie;

public class Smoothie
{
    private List<Ingredient> ingredientsList;
    private double precioBase;

    public Smoothie()
    {
        ingredientsList = new List<Ingredient>();
        precioBase = 100.0;
    }

    public List<Ingredient> IngredientsList
    {
        get { return ingredientsList; }
    }

    public void AddIngredient(Ingredient ing)
    {
        if (!IngredientsList.Contains(ing))
        {
            IngredientsList.Add(ing);
        }
    }

    public double GetTotalPrice()
    {
        double totalPrice = precioBase;
        foreach (var ing in IngredientsList)
        {
            totalPrice += ing.Cost;
        }

        return totalPrice;
    }

    public string GetFullName()
    {
        string name = "Batido de ";
        bool lastIng = false;
        foreach (var ing in ingredientsList)
        {
            if (ingredientsList.IndexOf(ing) == ingredientsList.Count - 1)
            {
                lastIng = true;
            }
            
            if (lastIng)
            {
                name += " y ";
            }
            else
            {
                name += ", ";
            }

            name += ing.Name.ToLower();
        }

        return name;
    }
}