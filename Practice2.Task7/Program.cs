using System.Text;

namespace Practice2.Task7;

// Напишите программу, которая переводит строку в разные регистры
// a. в верхний регистр: f -> F
// b. в нижний регистр: F -> f
// c. делает заглавную букву в слове: привет -> Привет

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FirstToUpper("aleksey"));
    }

    static string ToUpperCase(string str)
    {
        return str.ToUpper();
    }
    static string ToLowerCase(string str)
    {
        return str.ToLower();
    }

    static string FirstToUpper(string str)
    {
        return str[0].ToString().ToUpper() + str.Substring(1);
    }
    
}