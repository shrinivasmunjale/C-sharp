using System;

class Program
{
    static void Main()
    {
        int num ,  digit;
        int reverse =0;
        Console.Write("Enter the Number: ");
         num = Convert.ToInt32(Console.ReadLine());

        while (num > 0)
        {
            digit = num % 10;
            reverse = reverse *10 + digit;
            num =  num /10;
        }
        Console.WriteLine("The reverse number is : " + reverse);


       
    }
}