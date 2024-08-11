namespace Practice2.Task25;

// Создайте перечисление (enum) для дней недели. Напишите программу, которая
// считывает ввод пользователя и в зависимости от его ввода (число от 1 до 7)
// будет выводиться на экран консоли соответствующий день недели.

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Введите номер недели");
    int index = int.Parse(Console.ReadLine());
    Console.WriteLine(Enum.GetValues(typeof(Weeks)).GetValue(index - 1));
  }
}