using System;
using System.Collections.Generic;
using Zoo.Models;

namespace Zoo
{
  public class Program
  {
    private static List<Animal> _Animals = new List<Animal> { };
    private static int _CurrentId = 1;

    public static void Main()
    {
      Console.WriteLine("Welcome to your very own Zoo!");
      Start();
    }

    public static void Start()
    {
      Console.WriteLine("Would you like to add or see an animal [ADD/SEE/SEE ALL/QUIT]");
      string response = Console.ReadLine().ToLower();
      if (response == "add")
      {
        StoreAnimal(CreateAnimal());
        Start();
      }
      else if (response == "see")
      {
        Console.Write("Enter An id for the animal you wish to see:  ");
        int SearchId = int.Parse(Console.ReadLine());
        Animal found = FindById(SearchId);
        Console.WriteLine($"Id: {found.GetId()}, Species: {found.GetSpecies()}, Name: {found.GetName()}, Age: {found.GetAge()}, Location: {found.GetLocation()}.");
        Start();
      }
      else if (response == "see all")
      {

        foreach (Animal animal in GetAnimalList())
        {
          Console.WriteLine($"Id: {animal.GetId()}, Species: {animal.GetSpecies()}, Name: {animal.GetName()}");
        }
        Start();
      }
      else if (response == "quit")
      {
        Console.WriteLine("Good Bye!");
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
    public static int GetCurrentId()
    {
      return _CurrentId;
    }
    public static void IncrementID()
    {
      _CurrentId++;
    }
    public static Animal FindById(int id)
    {
      Animal temp = new Animal(0, "NA", 0, "NA", "NA");
      foreach (Animal animal in GetAnimalList())
      {
        if (animal.GetId() == id)
        {
          temp = animal;
        }
        else
        {
          Console.WriteLine("Sorry invalid Search");
        }
      }
      return temp;
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
      Animal TempAnimal = new Animal(GetCurrentId(), species, age, name, location);
      IncrementID();
      return TempAnimal;
    }
  }


}