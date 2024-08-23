namespace Practice5.Task1;
// Класс Employee. Делайте в одном проекте.
// a. Создайте базовый класс Employee с полями Name и Salary, а также
// методом CalculateBonus(), который возвращает 10% от зарплаты.
// Создайте производный класс Manager, который переопределяет метод
// CalculateBonus(), чтобы возвращать 20% от зарплаты. Создайте объекты
// обоих классов, вызовите метод и выведите результат на экран.
public class Employee
{
  public string Name { get; }
  public int Salary { get; }

  public Employee(string name, int salary)
  {
    this.Name = name;
    this.Salary = salary;
  }

  protected Employee(string name)
  {
    this.Name = name;
  }

  public virtual double CalculateBonus()
  {
    return (double)Salary / 10;
  }
}