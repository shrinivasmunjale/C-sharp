
using System;

class Program
{
    static void Main()
    {
        int num ,  digit;
        int sum =0;
        Console.Write("Enter the Number: ");
         num = Convert.ToInt32(Console.ReadLine());
        int original = num ;

        int digits = Convert.ToString(num).Length;
        
        while (num > 0)
        {
            digit = num % 10;
            sum = sum +(int) Math.Pow(digit, digits);

            num = num /10;
           
        }
       if(original == sum)
        {
             Console.WriteLine("Givin number is a Armstrong number...");
        }
        else
        {
            Console.WriteLine("Givin number is  Not a Armstrong number...");
        
        }


       
    }
}