namespace Practice2.Task9;

// Напишите метод, который создаёт массив целых чисел и возвращает его.
//     Размер массива нужно передавать в качестве аргумента. Вдобавок напишите
//     метод, который выводит переданный массив на экран консоли

class Program
{
    static void Main(string[] args)
    {
        PrintArray(CreateArray(5));
    }

    static int[] CreateArray(int size)
    {
        int[] array = new int[size];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.WriteLine(number);
        }
    }
}