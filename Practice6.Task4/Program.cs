namespace Practice6.Task4;

class Program
{
  static void Main(string[] args)
  {
    string filePath;

    while (true)
    {
      Console.Write("Введите путь к текстовому файлу: ");
      filePath = Console.ReadLine();

      try
      {
        string[] lines = File.ReadAllLines(filePath);
        
        foreach (var line in lines)
        {
          if (string.IsNullOrWhiteSpace(line))
          {
            throw new FormatException("Файл содержит некорректные данные (пустая строка).");
          }
          Console.WriteLine(line);
        }
        
        break;
      }
      catch (FileNotFoundException)
      {
        Console.WriteLine("Ошибка: Файл не найден. Пожалуйста, проверьте путь и попробуйте снова.");
      }
      catch (FormatException ex)
      {
        Console.WriteLine($"Ошибка: {ex.Message} Пожалуйста, исправьте данные в файле.");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Произошла ошибка: {ex.Message}. Пожалуйста, попробуйте снова.");
      }
    }
  }
}