namespace Practice6.Task2;

public class InsufficientFundsException : Exception
{
  public InsufficientFundsException(string message) : base(message)
  {
  }
}