using System;

class Program
{
    static int fractorial(int n)
    {
        
       if (n == 0)
        {
            return 1;
        }

        return n * fractorial(n - 1);
        
    }
    static void Main()
    {
        
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

       int result = fractorial(num);

       Console.WriteLine("factorial is : "+result);

    }
}