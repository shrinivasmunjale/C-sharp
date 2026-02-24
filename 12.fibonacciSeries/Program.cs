using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void FS(int n)
    {
        if (n < 1)
        {
            Console.WriteLine("given number is not valid for fibonscci Series");
           
        }
        else if(n == 1)
        {
            Console.WriteLine("Series: "+n);
        }
        else
        {
            int prev =0;
            int curr = 1;
            int next = prev + curr;
             Console.Write("Series: ");
            for(int i=0 ; i<n; i++)
            {
               
                Console.Write($"{next} ");
                prev = curr;
                curr=next;
                next = prev + curr;
                
            }
            
            
        }
    }
    static void Main()
    {
        Console.Write("Enter n number: ");
        int n = Convert.ToInt32(Console.ReadLine());

         FS(n);

        
    }
}