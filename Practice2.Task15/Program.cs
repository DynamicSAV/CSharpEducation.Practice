namespace Practice2.Task15;

// Создайте и реализуйте метод, который принимает на вход массив и
//   инвертирует его. Вызовите его в методе Main. Исходный массив задайте сами.
//   Инвертированный массив выведите на экран консоли.

class Program
{
  static void Main(string[] args)
  {
    int[] array = { 1, 2, 3, 4, 5 };
    int[] reversed = ReverseArray(array);
    PrintArray(reversed);
  }

  static int[] ReverseArray(int[] array)
  {
    int length = array.Length;
    
    int[] reversedArray = new int[length];

    for (int i = 0; i < length; i++)
    {
      reversedArray[length - 1 - i] = array[i];
    }
    return reversedArray;
  }

  static void PrintArray(int[] array)
  {
    foreach (var element in array)
    {
      Console.WriteLine(element);
    }
  }
}