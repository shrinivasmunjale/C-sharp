
using System;

class Program
{
    static void Main()
    {
        int num ,  digit;
        int sum =0;
        
        Console.Write("Enter the Number: ");
         num = Convert.ToInt32(Console.ReadLine());
        
        while (num > 0)
        {
            digit = num % 10;
            sum = sum  +digit;

            num = num /10;
           
        }
            Console.Write(sum);

       
    }
}