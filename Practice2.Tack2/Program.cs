namespace Practice2.Tack2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MeterToKilometer(1000));
        Console.WriteLine(KilometerToSantimeter(2));
        Console.WriteLine(MeterPerSecondToKilometerPerHour(2));
        Console.WriteLine(CelsiusToFarangeit(100));
        
    }

    static float MeterToKilometer(int meters)
    {
        return meters * 0.001f;
    }

    static float KilometerToSantimeter(int kilometers)
    {
        return kilometers * 1000 * 100;
    }

    static float MeterPerSecondToKilometerPerHour(float mps)
    {
        return mps * 3.6f;
    }

    static float CelsiusToFarangeit(float celsius)
    {
        return celsius * 1.8f + 32;
    }
}