using System;

namespace Zoo.Models
{
  public class Animal
  {
    private string Species;
    private int Age;
    private string Name;
    private string Location;


    public Animal(string species, int age, string name, string location)
    {
      Species = species;
      Age = age;
      Name = name;
      Location = location;

    }
  }
}
