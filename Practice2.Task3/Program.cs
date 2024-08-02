namespace Practice2.Task3;

/*Напишите программу для вычисления выражения (а + b — f / а) + f * a * a — (a +
b). Все переменные задаются пользователем. Учтите деление на 0*/

class Program
{
    static void Main(string[] args)
    {
        ReadCalculate();
    }

    static float Calculate(float a, float b, float f)
    {
        return (a + b - f / a) + f * a * a - (a + b);
    }

    static void ReadCalculate()
    {
        float a = 0;
        while (a == 0)
        {
            Console.WriteLine("Введите значение a, отличное от нуля: ");
            a = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Введите значение b: ");
        float b = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите значение f: ");
        float f = int.Parse(Console.ReadLine());
        
        Console.WriteLine(Calculate(a, b, f));
    }
}