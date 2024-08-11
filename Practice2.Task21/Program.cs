namespace Practice2.Task21;

// Напишите игру Угадай число. Программа случайно генерирует число от 1 до
// 100, а пользователь пытается угадать это число. При успешной догадке
// выводите поздравление пользователя.

class Program
{
  static void Main(string[] args)
  {
    StartGame();
  }

  static void StartGame()
  {
    Random random = new Random();
    int num = random.Next(1, 100);
    bool isWin = false;
    
    while (!isWin)
    {
      Console.WriteLine("Введите число");
      int playerNumber = int.Parse(Console.ReadLine());
      if (playerNumber == num)
      {
        isWin = true;
        Console.WriteLine("Победа!");
      }
      else
      {
        Console.WriteLine("Попытайтесь еще");
      }
    }
  }
}