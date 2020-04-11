using System;
 
class Kahearvukeskmine
{
    static void Main()
    {
 
        Console.WriteLine("Esimene nr: ");
        double a = double.Parse(Console.ReadLine());
 
        Console.WriteLine("Teine nr: ");
        double b = double.Parse(Console.ReadLine());
 
        double average = (a + b ) / 2;
        Console.WriteLine("Keskmine: {0}", average);
 
    }
}