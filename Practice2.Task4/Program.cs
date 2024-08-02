namespace Practice2.Task4;
/*Нарисуйте прямоугольный треугольник звёздочками. Чтобы высоту
треугольника можно было задавать программно*/
class Program
{
    static void Main(string[] args)
    {
        //DrawTriangle();
        //DrawInvertTriangle();
        DrawCustomTriangle('0');
    }

    static void DrawTriangle()
    {
        int height = 5;
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    
    static void DrawInvertTriangle()
    {
        int height = 5;
        for (int i = 1; i <= height; i++)
        {
            for (int j = 0; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    
    static void DrawCustomTriangle(char symbol)
    {
        int height = 5;
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine("");
        }
    }
}