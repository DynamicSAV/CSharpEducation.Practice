namespace Practice6.Task1;
using System.Text;

class Program
{
  static void Main()
  {
    bool validInput = false;

    do
    {
      try
      {
        Console.WriteLine("Введите путь к файлу");
        string path = Console.ReadLine();

        string textFromFile = File.ReadAllText(path);
        Console.WriteLine(textFromFile);
        string[] numbersArray = textFromFile.Split(" ");

        int num1 = int.Parse(numbersArray[0]);
        int num2 = int.Parse(numbersArray[1]);

        /*Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());*/

        double result = num1 / num2;
        Console.WriteLine($"Результат деления: {result}");
        validInput = true;
      }
      catch (FileNotFoundException)
      {
        Console.WriteLine("Файл по такому пути не найден");
      }
      catch (DivideByZeroException)
      {
        Console.WriteLine("Ошибка: деление на ноль. Пожалуйста, введите другое число.");
      }
      catch (FormatException)
      {
        Console.WriteLine("Ошибка: введены некорректные данные. Пожалуйста, введите числовые значения.");
      }
    } while (!validInput);
  }
}