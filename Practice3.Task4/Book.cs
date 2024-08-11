namespace Practice3.Task4;

// Создай класс "Книга" с полями "Название" и "Автор". Реализуй два конструктора:
// один с параметрами для инициализации полей, другой без параметров, который
// будет устанавливать значения по умолчанию.

public class Book
{
  public string name;
  public string author;

  public Book()
  {
    name = "Default";
    author = "Default";
  }

  public Book(string name, string author)
  {
    this.name = name;
    this.author = author;
  }
}