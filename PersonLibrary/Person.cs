namespace PersonLibrary;

public class Person(string name, int age)
{
  private string name = name;
  private int age = age;

  public void PrintPerson()
  {
    Console.WriteLine($"Name: {name}, Age: {age}");
  }
}