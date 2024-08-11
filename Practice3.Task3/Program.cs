namespace Practice3.Task3;

// Создай класс "Калькулятор" с методами для выполнения основных арифметических
// операций (сложение, вычитание, умножение, деление). Пусть эти методы
// принимают два числа и возвращают результат операции.


class Program
{
  static void Main(string[] args)
  {
    Calculator calculator = new Calculator();
    Console.WriteLine(calculator.Multiply(2, 3));
  }
}