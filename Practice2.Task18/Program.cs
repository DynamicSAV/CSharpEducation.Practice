namespace Practice2.Task18;

// Создайте и реализуйте метод, который будет принимать массив на вход убирать
// из него отрицательные числа и возвращать новый изменённый массив. Через
//   out параметр возвращать количество удалённых символов.


class Program
{
  static void Main(string[] args)
  {
    int[] array = { 1, 2, 0, -5, 1, -2, 5 };
    int[] positive = RemoveNegative(array, out int count);
    Console.WriteLine(count);
  }

  static int[] RemoveNegative(int[] array, out int count)
  {
    count = 0;
    int[] removedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] < 0)
      {
        removedArray[i] = array[i];
        count++;
      }
    }

    return removedArray;
  }
}