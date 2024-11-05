using System;

class Program
{
    static void Main()
    {
        char key;

        Console.WriteLine("Type characters (the program will stop if you type a digit):");

        do
        {
            key = Console.ReadKey(true).KeyChar; 

            if (!char.IsDigit(key)) 
            {
                Console.Write(key); 
            }

        } while (!char.IsDigit(key)); 

        Console.WriteLine(); 
        Console.WriteLine("A digit was entered. Program stopped.");
    }
}
