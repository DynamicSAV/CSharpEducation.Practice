namespace Practice2.Task10;

// Напишите программу, в которой создаётся массив и выводится на экран
// консоли. Размер массива передавайте в качестве первого аргумента командной
// строки.


class Program
{
    static void Main(string[] args)
    {
        CreateAndPrintArray(int.Parse(args[0]));
    }

    static void CreateAndPrintArray(int size)
    {
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = i;
        }

        foreach (var element in array)
        {
            Console.WriteLine(element);
        }
    }
}