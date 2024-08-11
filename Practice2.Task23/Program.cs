namespace Practice2.Task23;

// Напишите программу для вычисления високосного года.
//   a. год, номер которого кратен 400, — високосный;
// остальные годы, номер которых кратен 100, — невисокосные
// остальные годы, номер которых кратен 4, — високосный;
// все остальные годы — невисокосные.


class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine(IsLeapYear(1997));
  }

  static bool IsLeapYear(int year)
  {
    if (year % 400 == 0)
      return true;
    if (year % 100 == 0)
      return false;
    if (year % 4 == 0)
      return true;
    return false;
  }
}