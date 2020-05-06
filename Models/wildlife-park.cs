using System;

namespace Zoo.Models
{
  public class Animal
  {
    private int _Id;
    private string _Species;
    private int _Age;
    private string _Name;
    private string _Location;



    public Animal(int id, string species, int age, string name, string location)
    {
      _Id = id;
      _Species = species;
      _Age = age;
      _Name = name;
      _Location = location;
    }

    public int GetId()
    {
      return _Id;
    }

    public string GetSpecies()
    {
      return _Species;
    }
    public void SetSpecies(string input)
    {
      _Species = input;
    }

    public int GetAge()
    {
      return _Age;
    }
    public void SetAge(int input)
    {
      _Age = input;
    }

    public string GetName()
    {
      return _Name;
    }
    public void SetName(string input)
    {
      _Name = input;
    }

    public string GetLocation()
    {
      return _Location;
    }
    public void SetLocation(string input)
    {
      _Location = input;
    }
  }
}
