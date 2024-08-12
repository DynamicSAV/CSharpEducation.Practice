namespace Practice3.Task10;

class Program
{
  static void Main(string[] args)
  {
    Car car = new Car();
    PrintCarBrand(car);
  }

  static void PrintCarBrand(Car car)
  {
    Console.WriteLine(car.brand);
  }
}