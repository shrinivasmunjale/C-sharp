using System;

class Program
{
    static void Main()
    {
      Console.Write("Enter number: ");
      int num = Convert.ToInt32(Console.ReadLine()) ;

      if(num % 2 == 0)
        {
            Console.Write("Given number is even");
        }
        else
        {
            Console.Write(num+" number is odd");
        }

    }
}