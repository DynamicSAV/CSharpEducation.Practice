namespace Practice2.Task1;

class Program
{
    static void Main(string[] args)
    {
        //a
        for (int i = 0; i < 5; i++)
        {
            Console.Write(i);
        }
        
        //b
        int b = 3;
        while (b > 0)
        {
            Console.Write(b);
            b--;
        }
        
        //c
        int c = 3;
        do
        {
            Console.Write(c);
            c--;
        } while (c > 0);
        
        //d
        string letters = "";
        for (int i = 0; i < 3; i++)
        {
            letters += Console.ReadLine();
        }

        for (int i = 0; i < letters.Length; i++)
        {
            Console.Write(letters[i] + " ");
        }
        
        //e
        string letters2 = "";
        int e = 0;
        letters2 = Console.ReadLine();
        while (e < letters2.Length)
        {
            Console.WriteLine(letters2[e] + " ");
            e++;
        }
        
        //f
        string letters3 = "";
        int f = 0;

        letters3 = Console.ReadLine();
        do
        {
            Console.WriteLine(letters3[f] + " ");
            f++;
        } while (f <= letters3.Length);
    }
}