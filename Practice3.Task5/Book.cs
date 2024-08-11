namespace Practice3.Task5;

// Создай класс "Книга" с полями "Название" и "Автор". Реализуй два конструктора:
// один с параметрами для инициализации полей, другой без параметров, который
// будет устанавливать значения по умолчанию. Расширь класс "Книга" из
// предыдущего задания, добавив поле "Год издания". Реализуй цепочку
// конструкторов так, чтобы можно было создавать объекты класса "Книга" с
//   указанием только названия, названия и автора, или всех трех полей.

public class Book
{
  public string name;
  public string author;
  public int releaseYear;

  public Book()
  {
    name = "Default";
    author = "Default";
  }
  
  public Book(string name) : this()
  {
    this.name = name;
  }
  
  public Book(string name, string author) : this(name)
  {
    this.author = author;
  }

  public Book(string name, string author, int releaseYear) : this(name, author)
  {
    this.releaseYear = releaseYear;
  }

  public void Print()
  {
    Console.WriteLine($"name: {name}, author: {author}, releaseYear: {releaseYear}");
  }
}