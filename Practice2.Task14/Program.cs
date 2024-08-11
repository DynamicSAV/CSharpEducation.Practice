namespace Practice2.Task14;

// Создайте и реализуйте метод, который принимает на вход размер массива n и
//   возвращает пустой массив указанного размера. Вызовите метод в методе Main
//   и заполните его полученный массив. Содержимое массива выведите на экран.

class Program
{
  static void Main(string[] args)
  {
    int[] array = CreateArray(5);
    FillArray(array);
    PrintArray(array);
  }

  static int[] CreateArray(int n)
  {
    return new int[n];
  }

  static void FillArray(int[] array)
  {
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = random.Next(0, 10);
    }
  }

  static void PrintArray(int[] array)
  {
    foreach (var element in array)
    {
      Console.WriteLine(element);
    }
  }
}