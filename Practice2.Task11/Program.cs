namespace Practice2.Task11;

// Напишите программу, в которой создаётся массив и выводится на экран
// консоли. Размер массива передавайте в качестве первого аргумента командной
// строки. Число, которым будет заполняться массив передайте через второй
// аргумент командной строки

class Program
{
  private static int[] array;

  static void Main(string[] args)
  {
    CreateArray(int.Parse(args[0]), int.Parse(args[1]));
    PrintArray();
  }

  static void CreateArray(int size, int number)
  {
    array = new int[size];
    for (int i = 0; i < size; i++)
    {
      array[i] = number;
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