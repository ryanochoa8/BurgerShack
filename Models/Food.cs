namespace BurgerShack.Models
{
  abstract class Food
  {
    public string Name { get; private set; }
    public int Price { get; private set; }

    public override string ToString()
    {
      return $"{Name}: ${Price}";
    }


    public Food(string name, int price)
    {
      Name = name;
      Price = price;
    }
  }
}