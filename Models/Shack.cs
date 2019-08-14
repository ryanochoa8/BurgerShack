using System.Collections.Generic;

namespace BurgerShack.Models
{
  class Shack
  {
    public string Location { get; private set; }
    private List<Burger> AvailableBurgers { get; set; }
    private List<Side> AvailableSides { get; set; }

    public void PrintBurgers()
    {
      for (int i = 0; i < AvailableBurgers.Count; i++)
      {
        Burger f = AvailableBurgers[i];
        System.Console.WriteLine($"{i + 1}. {f}");
      }
    }
    public void PrintSides()
    {
      for (int i = 0; i < AvailableSides.Count; i++)
      {
        Side s = AvailableSides[i];
        System.Console.WriteLine($"{i + 1}. {s}");
      }
    }

    public void AddBurgers(Burger f)
    {
      AvailableBurgers.Add(f);
    }
    public void AddSides(Side s)
    {
      AvailableSides.Add(s);
    }

    public Shack(string location)
    {
      Location = location;
      AvailableBurgers = new List<Burger>();
      AvailableSides = new List<Side>();
    }



  }
}