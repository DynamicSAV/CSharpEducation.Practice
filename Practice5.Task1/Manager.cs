namespace Practice5.Task1;

public class Manager : Employee
{
  public int TemaSize { get; }
  public override double CalculateBonus()
  {
    return TemaSize > 5 ? (double)Salary / 20 : (double)Salary / 25;
  }

  public Manager(string name, int salary, int teamSize) : base(name, salary)
  {
    this.TemaSize = teamSize;
  }
}