using System.Security.AccessControl;

namespace Practice2.Task20;

// Создайте двумерный массив целых чисел произвольной длины и заполните
// случайными числами от 1 до 100. Выведите на экран разницу максимального и
// минимального значений в каждой строке массива.

class Program
{
  static void Main(string[] args)
  {
    int[,] matrix = new int[5, 5];
    FillMatrix(matrix);
    MinMaxDifference(matrix);
  }

  static void FillMatrix(int[,] matrix)
  {
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i, j] = random.Next(1, 100);
      }
    }
  }

  static void MinMaxDifference(int[,] matrix)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      int min = matrix[0,0];
      int max = matrix[0,0];
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        if (min > matrix[i, j])
          min = matrix[i, j];
        if (max < matrix[i, j])
          max = matrix[i, j];
      }

      Console.Write("Min: " + min + " ");
      Console.Write("Max: " + max + " ");
      Console.WriteLine("Difference: " + (max - min));
    }
  }
}