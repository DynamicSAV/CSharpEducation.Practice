namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        const float pi = 3.14f;
        float radius = 2f;

        float circleArea = 2 * pi * radius;
        
        Console.WriteLine($"Площадь круга с радиусом {radius} равна {circleArea}");
    }
}