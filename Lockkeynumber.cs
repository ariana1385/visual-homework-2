using System;

class Program
{
    static void Main()
    {
        char key;

        Console.WriteLine("Type characters (the program will stop if you type a letter):");

        do
        {
            key = Console.ReadKey(true).KeyChar;

            if (!char.IsLetter(key))
            {
                Console.Write(key);
            }

        } while (!char.IsLetter(key));

        Console.WriteLine();
        Console.WriteLine("A letter was entered. Program stopped.");
    }
}
