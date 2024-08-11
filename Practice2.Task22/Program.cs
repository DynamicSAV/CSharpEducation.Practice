namespace Practice2.Task22;

// Напишите игру Угадай число. Программа случайно генерирует число от 1 до
// 100, а пользователь пытается угадать это число. При успешной догадке
//   выводите поздравление пользователя. Также покажите количество попыток,
//   принятых пользователем.
//   a. Сделайте ограничение по попыткам. Например, если попыток больше 10,
//   то пользователь проиграл
//   b. Сделайте подсказки для пользователя. Если предположенное число
//   больше загаданного, то писать в консоль об этом. Аналогично и для
//   меньшего числа.

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
    int count = 0;
    bool isEndGame = false;

    while (!isEndGame)
    {
      count++;
      Console.WriteLine($"Введите число, попытка номер {count}");
      int playerNum = int.Parse(Console.ReadLine());
      if (playerNum == num)
      {
        Console.WriteLine("Победа!");
        isEndGame = true;
      }
      else if (count > 9)
      {
        isEndGame = true;
        Console.WriteLine("Вы проиграли");
      }
      else if (playerNum < num)
        Console.WriteLine("Загаданное число больше вашего");
      else if (playerNum > num)
        Console.WriteLine("Загаданное число меньше вашего");
    }
  }
}