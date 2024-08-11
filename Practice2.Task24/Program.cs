namespace Practice2.Task24;

// .Создайте перечисление (enum) для дней недели. Напишите программу, которая
// выводит на экран дни недели по названиям

class Program
{
  static void Main(string[] args)
  {
    PrintWeeks();
  }

  static void PrintWeeks()
  {
    foreach (Week week in Enum.GetValues(typeof(Week)))
    {
      Console.WriteLine(week);
    }
  }
}
