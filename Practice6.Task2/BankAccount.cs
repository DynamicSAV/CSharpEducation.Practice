namespace Practice6.Task2;

public abstract class BankAccount
{
  protected decimal balance;
  
  public void Deposit(decimal amount)
  {
    if (amount < 0)
      throw new NegativeAmountException("Сумма депозита не может быть отрицательной.");
    balance += amount;
  }

  public abstract void Withdraw(decimal amount);
  
  public void WithdrawSavingBalance(decimal amount)
  {

    if (amount < 0)
    {
      throw new NegativeAmountException("Сумма снятия не может быть отрицательной.");
    }
    if (amount > balance)
    {
      throw new InsufficientFundsException("Недостаточно средств для выполнения операции.");
    }
    balance -= amount;
  }

  public BankAccount(decimal initialBalance)
  {
    if (initialBalance < 0)
    {
      throw new NegativeAmountException("Начальный баланс не может быть отрицательным.");
    }
    this.balance = initialBalance;
  }

  public decimal GetBalance() => balance;
}