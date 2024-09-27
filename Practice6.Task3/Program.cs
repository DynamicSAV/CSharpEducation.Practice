namespace Practice6.Task3;

class Program
{
  static void Main(string[] args)
  {
    int age;
    int attempts = 0;
    const int maxAttempts = 3;

    while (true)
    {
      try
      {
        Console.Write("Введите ваш возраст: ");
        string input = Console.ReadLine();

        // Попытка преобразовать ввод в целое число
        if (!int.TryParse(input, out age))
        {
          throw new FormatException("Некорректный формат возраста. Пожалуйста, введите число.");
        }

        if (age < 0)
        {
          throw new ArgumentOutOfRangeException("Возраст не может быть отрицательным.");
        }

        if (age < 18)
        {
          throw new InvalidOperationException("Вы несовершеннолетний.");
        }
        
        Console.WriteLine("Вы совершеннолетний.");
        break;
      }
      catch (FormatException ex)
      {
        Console.WriteLine(ex.Message);
        attempts++;
      }
      catch (ArgumentOutOfRangeException ex)
      {
        Console.WriteLine(ex.Message);
        attempts++;
      }
      catch (InvalidOperationException ex)
      {
        Console.WriteLine(ex.Message);
        break;
      }
      
      if (attempts >= maxAttempts)
      {
        throw new TooManyAttemptsException("Слишком много неверных попыток ввода возраста.");
      }
    }
  }
}
