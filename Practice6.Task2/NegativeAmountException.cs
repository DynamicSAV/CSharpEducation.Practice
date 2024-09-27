namespace Practice6.Task2;

public class NegativeAmountException  : Exception
{
  public NegativeAmountException(string message) : base(message)
  {
  }
}