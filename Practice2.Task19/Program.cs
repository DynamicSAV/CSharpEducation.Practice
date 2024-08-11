
namespace Practice2.Task19;

// Создайте одномерный массив целых чисел произвольной длины и заполните
//   случайными числами от 1 до 100. Выведите на экран разницу максимального и
//   минимального значений в нём.


class Program
{
  static void Main(string[] args)
  {
    int[] array = new int[50];
    FillArray(array);
    Console.WriteLine("Difference: " + GetMinMaxDifference(array));
  }

  static void FillArray(int[] array)
  {
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = random.Next(1, 100);
    }
  }

  static int GetMinMaxDifference(int[] array)
  {
    int min = array[0];
    int max = array[0];

    foreach (var element in array)
    {
      if (element < min)
        min = element;
      if (element > max)
        max = element;
    }

    Console.WriteLine("min " + min);
    Console.WriteLine("max " + max);
    return max - min;
  }
}