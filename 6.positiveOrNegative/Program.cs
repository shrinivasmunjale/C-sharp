using System ;
class Program
{
    static void Main()
    {
        Console.Write("Enter the any number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0)
        {
            Console.WriteLine(num+" is positive number.");
        }
        else
        {
            Console.WriteLine(num+" is negative number.");
        }
    }
}