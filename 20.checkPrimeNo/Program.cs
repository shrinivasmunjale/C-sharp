using System;

class Program
{
    static void Main()
    {
        int temp =0;
        Console.Write("Enter the Number: ");
        int num = int.Parse(Console.ReadLine());

        for( int i =1 ; i<= num ; i++)
        {
            if(num % i == 0)
            {
                temp ++;
            }
        }
        if(temp == 2)
        {
            Console.Write("given number is prime number: ");
        }
        else
        {
            Console.Write("given number is not a prime number: ");
        }
    }
}