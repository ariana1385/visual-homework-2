using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is in the Fibonacci series:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (IsFibonacci(n))
        {
            Console.WriteLine( "n is in the Fibonacci series.");
        }
        else
        {
            Console.WriteLine( "n is not in the Fibonacci series.");
        }
    }

    static bool IsFibonacci(int number)
    {
        if (number < 0)
        {
            return false;
        }
        int a = 0;
        int b = 1;
        int temp;
        while (b < number)
        {
            temp = a + b; 
            a = b;        
            b = temp;
        }
        return b == number;
    }
}


