namespace Practice2.Task16;

// Создайте и реализуйте метод, который будет принимать число по ссылке (ref) и
//   менять его знак на противоположный. Метод должен принимать один аргумент и
// не возвращать ничего.


class Program
{
  static void Main(string[] args)
  {
    int number = -10;
    Console.WriteLine(number);
    InvertNumber(ref number);
    Console.WriteLine(number);
  }

  static void InvertNumber(ref int number)
  {
    number = -number;
  }
}