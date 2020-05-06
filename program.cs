using System;
using System.Collections.Generic;
using Zoo.Models;

namespace Zoo
{
  public class Program
  {
    private static List<Animal> _Animals = new List<Animal> { };

    public static void Main()
    {
      Console.WriteLine("Welcome to your very own Zoo!");
      Start();
    }

    public static void Start()
    {
      Console.WriteLine("Would you like to add or see an animal [ADD/SEE/SEE ALL]");
      string response = Console.ReadLine().ToLower();
      if (response == "add")
      {
        StoreAnimal(CreateAnimal());
        Start();
      }
      else if (response == "see")
      {
        //something else with the animals
        Start();
      }
      else if (response == "see all")
      {

        foreach (Animal animal in GetAnimalList())
        {
          Console.WriteLine($"Species: {animal.GetSpecies()}, Name: {animal.GetName()}");
        }
        Start();
      }
      else
      {
        Console.WriteLine("Spell correctly please");
        Start();
      }
    }

    public static List<Animal> GetAnimalList()
    {
      return _Animals;
    }
    public static void StoreAnimal(Animal animal)
    {
      _Animals.Add(animal);
    }
    public static Animal CreateAnimal()
    {
      Console.Write("Enter a Species: ");
      string species = Console.ReadLine();
      Console.Write("Enter an Age: ");
      int age = int.Parse(Console.ReadLine());
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      Console.Write("Enter a location: ");
      string location = Console.ReadLine();
      Animal TempAnimal = new Animal(species, age, name, location);
      return TempAnimal;
    }
  }


}