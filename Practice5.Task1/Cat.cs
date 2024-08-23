namespace Practice5.Task1;

public class Cat : Animal
{
  public Cat(string name, int age) : base(name, age)
  {
    Console.WriteLine("Cat created");
  }

  public override void MakeSound()
  {
    Console.WriteLine("Meow!");
  }
}