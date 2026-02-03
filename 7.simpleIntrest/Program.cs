using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the principle amount: ");
        int p = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Interest Rate: ");
        int r = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Time Peraid in year: ");
        int t = Convert.ToInt32(Console.ReadLine());

        int result = (p*r*t)/100;

        Console.WriteLine("Simple Interest is: "+ result);

        int total = p + result ;

        Console.WriteLine("Totle Amount including interest is: "+ total);

    }
}