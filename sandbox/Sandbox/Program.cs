using System;

class Program
{
    static void Main(string[] args)
    {
     Console.WriteLine($"Hello World!");
     person person1 = new person("John", "Doe", 25, 180);
     Fireman fireman1 = new Fireman("Emt and Parametic", "Jane", "Doe", 30, 150);
     
        Console.WriteLine(person1.PersonInformantion());
        Console.WriteLine(fireman1.PersonInformantion());
        Console.WriteLine(fireman1.FiremanInformation());

    }
}









