namespace Practice5.Task1;
using LoggerLibrary;

class Program
{
  static void Main(string[] args)
  {
    List<Animal> animals = new List<Animal>
    {
      new Dog("Сабака", 2),
      new Cat("василиса", 2),
      new Parrot("Ублюдок попугай", 1)
    };

    IFlyable[] flyables = new IFlyable[]
    {
      new Eagle("Eagle", 1),
      new Parrot("Parrot", 2),
    };
    
    ILogger consoleLogger = new ConsoleLogger();
    ILogger fileLogger = new FileLogger("log.txt");
    
    Employee employee = new Employee("Pavel", 50000);
    Manager manager = new Manager("Roma", 80008, 5);
    Contractor contractor = new Contractor("Dima", 450);
    
    Console.WriteLine(employee.CalculateBonus());
    Console.WriteLine(manager.CalculateBonus());
    Console.WriteLine(contractor.CalculateBonus(200));
    
    consoleLogger.Info("Это информационное сообщение.");
    fileLogger.Error("Это сообщение об ошибке.");
    
    foreach (var animal in animals)
    {
      animal.MakeSound();
    }

    for (int i = 0; i < flyables.Length - 1; i++)
    {
      flyables[i].Fly();
    }
  }
}