namespace Practice6.Task2;

public class SavingAccount : BankAccount
{
  private DateTime lastWithdrawalDate;
  
  public SavingAccount(decimal initialBalance) : base(initialBalance)
  {
    lastWithdrawalDate = DateTime.MinValue;
  }

  public override void Withdraw(decimal amount)
  {
    if (amount < 0)
    {
      throw new NegativeAmountException("Сумма снятие не может быть отрицательной.");
    }

    if (amount > balance)
    {
      throw new InsufficientFundsException("Недостаточно средств для выполнения операции.");
    }

    if (lastWithdrawalDate.AddMonths(1) > DateTime.UtcNow)
    {
      throw new WithdrawalLimitExceededException("Нельзя снимать деньги чаще, чем раз в месяц.");
    }
    lastWithdrawalDate = DateTime.UtcNow;
    balance -= amount;
  }
}