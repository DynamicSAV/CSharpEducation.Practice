namespace Practice3.Task2;

// Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
// выводить информацию о студенте в консоль. Добавь в класс "Студент" свойство
// "Средний балл". Реализуй геттер и сеттер для этого свойства. Добавь проверку в
// сеттер, чтобы значение среднего балла было в диапазоне от 0 до 5.


public class Student
{
  private string name;
  private int age;
  private float averageScore;

  public float AverageScore
  {
    get => averageScore;
    set
    {
      if (value >= 0 && value <= 5)
      {
        averageScore = value;
      }
    }
  }

  public void Print()
  {
    Console.WriteLine($"Name:  {name}");
    Console.WriteLine($"Age:  {age}");
    Console.WriteLine($"AverageScore:  {AverageScore}");
  }
}