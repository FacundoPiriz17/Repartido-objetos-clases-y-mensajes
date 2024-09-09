using System;
namespace CalculadoraSmoothie;

public class Program
{
    public static void Main()
    {
        Ingredient banana = new Ingredient("Banana", 25.5);
        Ingredient frutilla = new Ingredient("Frutilla", 40.0);
        Smoothie licuado = new Smoothie();
        licuado.AddIngredient(banana);
        licuado.AddIngredient(frutilla);
        
        foreach (var ingredient in licuado.IngredientsList)
        {
            Console.WriteLine(ingredient.Name);
        }
        
        Console.WriteLine(licuado.GetTotalPrice());
        Console.WriteLine(licuado.GetFullName());
        
    }
}