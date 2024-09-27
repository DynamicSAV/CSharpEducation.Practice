namespace Practice6.Task2;

public class RegularAccount : BankAccount
{
  public RegularAccount(decimal initialBalance) : base(initialBalance)
  {
  }

  public override void Withdraw(decimal amount)
  {
    if (amount < 0)
    {
      throw new NegativeAmountException("Сумма снятия не может быть отрицательной.");
    }
    if (amount > 0)
    {
      throw new InsufficientFundsException("Недостаточно средств для совершения операции.");
    }

    balance -= amount;
  }
}