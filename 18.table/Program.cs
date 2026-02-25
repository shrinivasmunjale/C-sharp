using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int i;
        Console.Write("Enter the number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Multiplication table of :"+num);
        for( i = 1 ; i<=10 ; i++){
            int Total = num * i;

            Console.WriteLine($"{num} * {i} = {Total}");
        }

    }
}