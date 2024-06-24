using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1);
        // fraction1.SetTop(5);
        // fraction1.GetBottom();
        // Console.WriteLine(fraction1.GetBottom());
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine(fraction2);
        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine(fraction3);

        fraction2.SetTop(5);
        fraction3.SetTop(3);
        fraction3.SetBottom(4);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        fraction3.SetTop(1);
        fraction3.SetBottom(3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
    }
}