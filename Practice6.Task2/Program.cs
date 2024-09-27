namespace Practice6.Task2;

class Program
{
  static void Main(string[] args)
  {
    SavingAccount savingAccount = new SavingAccount(100);
    try
    {
      savingAccount.Deposit(1);
      
      savingAccount.Withdraw(10);
      Console.WriteLine(savingAccount.GetBalance());

      savingAccount.Withdraw(10);

      Console.WriteLine(savingAccount.GetBalance());
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
  }
}