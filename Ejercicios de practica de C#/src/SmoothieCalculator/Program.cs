using System;
namespace SmoothieCalculator;

public class Program
{
    public static void Main()
    {
        Ingredient banana = new Ingredient("Banana", 25.5);
        Ingredient frutilla = new Ingredient("Frutilla", 40.0);
        Ingredient kiwi = new Ingredient("Kiwi", 15.00);
        Smoothie licuado = new Smoothie();
        licuado.AddIngredient(banana);
        licuado.AddIngredient(frutilla);
        licuado.AddIngredient(kiwi);
        
        foreach (var ingredient in licuado.IngredientsList)
        {
            Console.WriteLine(ingredient.Name);
        }
        
        Console.WriteLine(licuado.GetTotalPrice());
        Console.WriteLine(licuado.GetFullName());
        
    }
}