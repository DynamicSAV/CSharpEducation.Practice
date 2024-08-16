namespace Practice4.Task1;
// Создай библиотеку классов, в которой будет класс "MathHelper" с методами для
// выполнения основных математических операций (сложение, вычитание, умножение,
// деление). Убедись, что библиотека компилируется без ошибок.
using MathHelperLibrary;

class Program
{
  static void Main(string[] args)
  {
    MathHelper mathHelper = new MathHelper();

    Console.WriteLine(mathHelper.Add(1,2));
    Console.WriteLine(mathHelper.Divide(1,2));
    Console.WriteLine(mathHelper.Multiplication(1,2));
    Console.WriteLine(mathHelper.Substract(1,2));
  }
}