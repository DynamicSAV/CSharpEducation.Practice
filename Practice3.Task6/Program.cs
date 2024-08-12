namespace Practice3.Task6;

// Создай структуру "Точка" с полями "X" и "Y" типа int. Напиши метод, который будет
// принимать две точки и возвращать расстояние между ними.

class Program
{
  static void Main(string[] args)
  {
    Point a = new Point();
    a.X = 3;
    a.Y = 2;
    
    Point b = new Point();
    b.X = 4;
    b.Y = 10;
    
    Console.WriteLine(LengthBetweenPoints(a, b));
  }

  private static double LengthBetweenPoints(Point a, Point b)
  {
    return (Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2)));
  }
}