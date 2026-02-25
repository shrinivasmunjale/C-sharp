using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the Straring Number: ");
        int start = int.Parse(Console.ReadLine());

        
        Console.Write("Enter the Ending Number: ");
        int end = int.Parse(Console.ReadLine());

        for(int num = start ; num<= end ; num++)
        {
            if (num <= 1)
            {
                continue;
            }
            bool isPrime = true;
            for( int i=2 ; i<= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                 Console.Write(num + " ");
            }
        }


    }
}