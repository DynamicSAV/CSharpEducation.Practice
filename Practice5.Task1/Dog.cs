namespace Practice5.Task1;

public class Dog : Animal
{
  public Dog(string name, int age) : base(name, age)
  {
    Console.WriteLine("Dog created");
  }

  public override void MakeSound()
  {
    Console.WriteLine("Woof!");
  }
}