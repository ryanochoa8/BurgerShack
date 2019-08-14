using System;
using BurgerShack.Models;

namespace BurgerShack
{
  class Program
  {
    static void Main(string[] args)
    {
      Shack bs = new Shack("Eagle Location");

      Burger doubleCheeseBurger = new Burger("Double Cheese Burger", 6);
      Burger cheeseBurger = new Burger("Cheese Burger", 5);
      Burger bajaBurger = new Burger("Baja Burger", 7);
      Burger bleuBurger = new Burger("Bleu Cheese Burger", 7);
      Burger teryakiBurger = new Burger("Teryaki Burger", 8);

      Side smallFries = new Side("Small Fries", 2);
      Side largeFries = new Side("Large Fries", 3);
      Side smallOnionRings = new Side("Small Onion Rings", 3);
      Side largeOnionRings = new Side("Large Onion Rings", 4);


      bs.AddBurgers(doubleCheeseBurger);
      bs.AddBurgers(cheeseBurger);
      bs.AddBurgers(bajaBurger);
      bs.AddBurgers(bleuBurger);
      bs.AddBurgers(teryakiBurger);

      bs.AddSides(smallFries);
      bs.AddSides(largeFries);
      bs.AddSides(smallOnionRings);
      bs.AddSides(largeOnionRings);







      Console.Clear();
      Console.WriteLine(@"
        
    ____                                _____ __               __  
   / __ )__  ___________ ____  _____   / ___// /_  ____ ______/ /__
  / __  / / / / ___/ __ `/ _ \/ ___/   \__ \/ __ \/ __ `/ ___/ //_/
 / /_/ / /_/ / /  / /_/ /  __/ /      ___/ / / / / /_/ / /__/ ,<   
/_____/\__,_/_/   \__, /\___/_/      /____/_/ /_/\__,_/\___/_/|_|  
                 /____/                                          



                            OUR MENU
        ");


      System.Console.WriteLine(@"
Burgers: 
");
      bs.PrintBurgers();

      System.Console.WriteLine(@"
Sides: 
");
      bs.PrintSides();
    }
  }
}
