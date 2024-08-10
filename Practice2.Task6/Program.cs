using System.Threading.Channels;

namespace Practice2.Task6;

// Введите с клавиатуры строку произвольной длины
// и подсчитайте процент вхождения заданного символа в строку.
// a. строка и символ указываются программно
// b. строка и символ указываются пользователем в консоли
// c. строка и символ указываются через аргументы командной строки

class Program
{
    static void Main(string[] str)
    {
        Console.WriteLine(PercenOfSybmolArguments(str[0], str[1]));
    }

    static float PercenOfSybmol()
    {
        char symbol = 'a';
        string str = "amama";
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == symbol)
            {
                count++;
            }
        }

        Console.WriteLine(count);

        return(100 / (float)str.Length) * count;
    }
    
    static float PercenOfSybmolConsole()
    {
        string str = Console.ReadLine();
        char symbol = char.Parse(Console.ReadLine());

        int count = 0;
        
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == symbol)
            {
                count++;
            }
        }
        return(100 / (float)str.Length) * count;
    }
    
    static float PercenOfSybmolArguments(string str, string symbol)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == char.Parse(symbol))
            {
                count++;
            }
        }

        Console.WriteLine(count);

        return(100 / (float)str.Length) * count;
    }
}