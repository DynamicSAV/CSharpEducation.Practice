namespace Practice3.Task8;

class Program
{
  static void Main(string[] args)
  {
    Rectangle rectangle = new Rectangle();
    rectangle.height = 3;
    rectangle.width = 2;
    Console.WriteLine(CalculateTheArea(rectangle));
  }

  static double CalculateTheArea(Rectangle rectangle)
  {
    return rectangle.width * rectangle.height;
  }
}