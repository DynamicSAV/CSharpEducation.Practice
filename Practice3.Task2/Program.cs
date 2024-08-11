namespace Practice3.Task2;

// Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
// выводить информацию о студенте в консоль. Добавь в класс "Студент" свойство
// "Средний балл". Реализуй геттер и сеттер для этого свойства. Добавь проверку в
// сеттер, чтобы значение среднего балла было в диапазоне от 0 до 5.


class Program
{
  static void Main(string[] args)
  {
    Student student = new Student();
    student.Print();
    student.AverageScore = 6f;
    student.Print();
    student.AverageScore = 2.4f;
    student.Print();
  }
}