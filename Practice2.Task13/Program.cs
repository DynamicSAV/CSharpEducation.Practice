
namespace Practice2.Task13;
// Напишите метод, который создаёт двумерный массив (не зубчатый). Размеры
// массива передавайте через аргументы метода. Также напишите отдельный
// метод для вывода двумерного массива в виде матрицы на экран консоли.
// Массив заполните случайными числами.


class Program
{
  static void Main(string[] args)
  {
    int[,] array = CreateTwoDimensionalArray(5);
    PrintTwoDimensionalArray(array);

  }

  static int[ , ] CreateTwoDimensionalArray(int size)
  {
    int[ , ] array = new int[size, size];
    Random random = new Random();
    
    for (int i = 0; i < size; i++)
    {
      for (int j = 0; j < size; j++)
      {
        array[i, j] = random.Next(0, 10);
      }
    }

    return array;
  }

  static void PrintTwoDimensionalArray(int [,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(0); j++)
      {
        Console.Write(array[i,j]);
      }
      Console.WriteLine();
    }
  }
}