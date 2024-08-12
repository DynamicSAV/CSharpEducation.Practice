namespace Practice3.Task7;

// Создай перечисление "Месяцы" с элементами, представляющими названия
//   месяцев года. Напиши метод, который будет принимать месяц и возвращать
//   количество дней в этом месяце

class Program
{
  static void Main(string[] args)
  {
    Month month = Month.April;
    Console.WriteLine(ReturnDaysInMonth(month));
  }

  private static int ReturnDaysInMonth(Month month)
  {
    switch (month)
    {
      case Month.January:
        return 31;
      case Month.February:
        return 29;
      case Month.March:
        return 31;
      case Month.April:
        return 30;
      case Month.May:
        return 31;
      case Month.June:
        return 30;
      case Month.July:
        return 31;
      case Month.August:
        return 31;
      case Month.September:
        return 30;
      case Month.October:
        return 31;
      case Month.November:
        return 30;
      case Month.December:
        return 31;
    }
    return -1;
  }
}