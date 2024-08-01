namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        float catheter1 = 10;
        float catheter2 = 4;
        float hypotenuse = 13;
        
        Console.WriteLine(calculateHypotenuse(catheter1, catheter2));
        Console.WriteLine(calculateSecondCatheter(catheter1, hypotenuse));
    }

    static double calculateHypotenuse(float catheter1, float catheter2)
    {
        return Math.Sqrt(catheter1 * catheter1 + catheter2 * catheter2);
    }
    
    static double calculateSecondCatheter(float catheter, float hypotenuse)
    {
        return Math.Sqrt(hypotenuse * hypotenuse - catheter * catheter);
    }
}