using System;
using System.Buffers;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void swap(int a, int b)
    {
        int num1 = a;
        int num2 = b;
        int temp =0;

        temp = num2;
        num2 = num1;
        num1=temp;

        Console.WriteLine("afrer swaping num 1: "+num1);
         Console.Write("afrer swaping num 2: "+num2);

    }
    static void Main(){
        int a = 12;
        int b =32;

        swap(a,b);
    }
}