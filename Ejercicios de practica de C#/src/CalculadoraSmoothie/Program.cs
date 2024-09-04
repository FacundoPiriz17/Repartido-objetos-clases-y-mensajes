﻿namespace CalculadoraSmoothie;
using System;

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
}