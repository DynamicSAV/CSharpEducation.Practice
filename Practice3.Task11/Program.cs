namespace Practice3.Task11;

class Program
{
  static void Main(string[] args)
  {
    Book book = new Book();
    Console.WriteLine(ReturnBookInformation(book));
  }

  static string ReturnBookInformation(Book book)
  {
    return $"name: {book.name}, author: {book.author}";
  }
}