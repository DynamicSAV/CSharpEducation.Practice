namespace Practice3.Task1;

// Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
// выводить информацию о студенте в консоль

class Program
{
  static void Main(string[] args)
  {
    Student student = new Student();
    student.Print();
  }
}