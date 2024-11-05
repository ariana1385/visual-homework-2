using System;

class Program
{
    static void Main()
    { Console.WriteLine("Enter the starting number(n):");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the the ending number(m):");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        
        for (int j = n; j <= m; j++)
        {
            if (IsPalindrome(j))
            {
                Console.WriteLine(j);
            }
        }
    }
    static bool IsPalindrome(int number)
    {
        if (number < 0 || (number % 10 == 0 && number != 0))
        {
            return false;
        }

        int reversedNumber = 0;
        int originalNumber = number;
        while (number > 0)
        { int i = number % 10;
            reversedNumber = reversedNumber * 10 + i;
            number /= 10;
        }
        return originalNumber == reversedNumber;
    }
}
