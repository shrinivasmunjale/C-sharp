using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int num = int.Parse(Console.ReadLine());

        int digit = num.ToString().Length;

        Console.Write($"the digit is {num} is {digit}");

    }
}