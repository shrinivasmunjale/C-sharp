using System;


class Program
{
    static void Main()
    {
        int gcd=1;
        int lcm;
        
        Console.Write("Enter the first Number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter the second Number: ");
        int second = int.Parse(Console.ReadLine());

        int min = (first < second) ? first : second;

        for(int i = 1 ; i<=min ; i++)
        {
            if(first % i == 0 && second % i == 0 )
            {
                gcd = i;
            }
        }

        lcm = (first * second)/gcd;

        Console.WriteLine("GCD is :"+gcd);
        Console.WriteLine("LCM of given numbers: "+lcm);


    }
}