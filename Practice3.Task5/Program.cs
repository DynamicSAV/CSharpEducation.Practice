﻿namespace Practice3.Task5;

// Создай класс "Книга" с полями "Название" и "Автор". Реализуй два конструктора:
// один с параметрами для инициализации полей, другой без параметров, который
// будет устанавливать значения по умолчанию. Расширь класс "Книга" из
// предыдущего задания, добавив поле "Год издания". Реализуй цепочку
// конструкторов так, чтобы можно было создавать объекты класса "Книга" с
// указанием только названия, названия и автора, или всех трех полей.

class Program
{
  static void Main(string[] args)
  {
    Book book = new Book();
    Book book2 = new Book("book", "noName", 1290);
    book.Print();
    book2.Print();
  }
}