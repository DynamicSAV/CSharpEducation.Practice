namespace Practice2.Task8;

// Составить алгоритм увеличения всех трех, введенных с клавиатуры,
//     переменных на 5,если среди них есть хотя бы две равные. В противном случае
//     выдать ответ «равных нет».

class Program
{
    static void Main(string[] args)
    {
        MultiplyToFive();
    }

    static void MultiplyToFive()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a == b || a == c)
        {
            a *= 5;
            b *= 5;
            c *= 5;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine("Равных нет");
        }
    }
}