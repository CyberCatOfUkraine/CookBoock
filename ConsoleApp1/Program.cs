using System;
using System.Collections.Generic;
using DAL.Models;
using DAL.UoW;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var uoW=new UoW();
            var ingredients1=new Ingredients {Name = "Ingredient 1"};
            var ingredients2=new Ingredients {Name = "Ingredient 2"};
            var recipe=new Recipe {Name = "recipe1",Description = "Some test",Ingredients = new List<Ingredients> {ingredients1,ingredients2}};
            var dish=new Dish{Name = "Dish 1",Recipe = recipe};
            uoW.GetIngredientsRepo.Add(ingredients1);
            uoW.GetIngredientsRepo.Add(ingredients2);
            uoW.GetRecipeRepo.Add(recipe);
            uoW.GetDishRepo.Add(dish);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Dish:\n" +
                              $"* Name: {dish.Name}\n" +
                              $"* Recipe name: {dish.Recipe.Name}");
        }
    }
}