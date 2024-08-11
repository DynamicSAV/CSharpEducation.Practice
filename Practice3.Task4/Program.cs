namespace Practice3.Task4;

class Program
{
  static void Main(string[] args)
  {
    Book book1 = new Book();
    Book book2 = new Book("MegaBook", "MegaMan");

    Console.WriteLine(book1.name + " " + book2.name);
  }
}