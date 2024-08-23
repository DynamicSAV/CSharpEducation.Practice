namespace PersonLibrary;

public class Person(string name, int age)
{
  private string name { get; } = name;
  private int age { get; } = age;

  public void PrintPerson()
  {
    Console.WriteLine($"Name: {name}, Age: {age}");
  }
}