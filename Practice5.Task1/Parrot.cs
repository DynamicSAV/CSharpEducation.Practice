namespace Practice5.Task1;

public class Parrot : Animal, IFlyable
{
  public Color color;
  
  public Parrot(string name, int age) : base(name, age)
  {
  }

  public new void MakeSound(string words)
  {
    Console.WriteLine("Parrot is talking");
    for (int i = 0; i < 5; i++)
    {
      Console.WriteLine(words);
    }
  }

  public void Fly()
  {
    Console.WriteLine("Parrot is flying");
  }
}