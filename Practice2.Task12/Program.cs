namespace Practice2.Task12;

// Напишите программу, в которой создаётся массив строк, который заполняется
// пользователем через консоль. Затем этот массив должен быть выведен на
// экран консоли.

class Program
{
  static string[] array;
  
  static void Main(string[] args)
  {
    CreateArray();
    PrintArray();
  }

  static void CreateArray()
  {
    string inputText;
    Console.WriteLine("Введите размер массива");
    int size = int.Parse(Console.ReadLine());
    array = new string[size];

    for (int i = 0; i < size; i++)
    {
      Console.WriteLine("Введите элемент массива");
      inputText = Console.ReadLine();
      array[i] = inputText;
    }
  }

  static void PrintArray()
  {
    foreach (var element in array)
    {
      Console.WriteLine(element);
    }
  }
}