using System.Globalization;

namespace Practice3.Task9;

class Program
{
  static void Main(string[] args)
  {
    Student student = new Student();
    Console.WriteLine(student.name);
    
    RenameStudentToAnonim(student);
    Console.WriteLine(student.name);
  }

  static void RenameStudentToAnonim(Student student)
  {
    student.name = "Anonim";
  }
}