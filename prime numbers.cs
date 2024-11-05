using System;

class Program
{
    static void Main()
    {
     Console.WriteLine("enter the starting number (n) ");
     int n = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("enter the ending number (m) ");
        int m = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();

        for (int j = n; j <= m; j++)
        {
            if (IsPrime(j))
            {
                Console.WriteLine(j);
            }
        }
    }
    static bool IsPrime (int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

