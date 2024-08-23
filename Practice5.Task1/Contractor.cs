namespace Practice5.Task1;

public class Contractor : Employee
{
  public int HourlyRate { get; }

  public new double CalculateBonus(int hoursWorked)
  {
    return HourlyRate * hoursWorked;
  }

  public Contractor(string name, int hourlyRate) : base(name)
  {
    this.HourlyRate = hourlyRate;
  }
}