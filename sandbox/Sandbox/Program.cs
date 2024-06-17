using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!!");

        Circle myCirlce = new Circle(10);
        Console.WriteLine($"Area of circle is {myCirlce.GetArea()}");
        Circle unitCircle = new Circle(1);
        Console.WriteLine($"{unitCircle.GetCircumference()}");
        Console.WriteLine($"{unitCircle.GetDiameter()}");

    }
}