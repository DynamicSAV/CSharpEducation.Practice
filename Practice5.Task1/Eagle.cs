namespace Practice5.Task1;

public class Eagle : Animal, IFlyable
{
  public void Fly()
  {
    Console.WriteLine("Eagle is soaring high");
  }

  public Eagle(string name, int age) : base(name, age)
  {
  }
}