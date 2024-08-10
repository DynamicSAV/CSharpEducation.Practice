namespace Practice2.Task5;

// Напишите программу для сравнения двух целых чисел. Ввод осуществляйте
// через консоль.

class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"{a} больше {b}");
        } else if (a < b)
        {
            Console.WriteLine($"{b} больше {a}");
        }
        else
        {
            Console.WriteLine($"{a} равно {b}");
        }
    }
}