namespace Practice2.Task17;

// Создайте и реализуйте метод, который будет принимать два числа и менять их
// значения местами. Вызовите метод в Main.


class Program
{
  static void Main(string[] args)
  {
    int num1 = 10;
    int num2 = 20;
    
    Console.WriteLine($"{num1}  {num2}");
    SwapNumbers(ref num1,ref num2);
    Console.WriteLine($"{num1}  {num2}");
  }

  static void SwapNumbers(ref int first, ref int second)
  {
    first += second;
    second = first - second;
    first -= second;
  }
}