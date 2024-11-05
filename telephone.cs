using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a 10-digit phone number starting with '0':");
        string input = Console.ReadLine();

        if (IsValidPhoneNumber(input))
        {
            Console.WriteLine("Valid Phone Number: " + input);
        }
        else
        {
            Console.WriteLine("Invalid Phone Number. Ensure it starts with '0', is 10 digits long, and contains at least two different digits.");
        }
    }

    static bool IsValidPhoneNumber(string phoneNumber)
    {
        bool isLengthValid = phoneNumber.Length == 10;
        bool startsWithZero = phoneNumber[0] == '0';
        bool allDigits = IsAllDigits(phoneNumber); 

        if (!isLengthValid || !startsWithZero || !allDigits)
        {
            return false; 
        }

        return HasAtLeastTwoDifferentDigits(phoneNumber);
    }

    static bool HasAtLeastTwoDifferentDigits(string phoneNumber)
    {
        char firstDigit = phoneNumber[0];
        for (int i = 1; i < phoneNumber.Length; i++)
        {
            if (phoneNumber[i] != firstDigit)
            {
                return true;
            }
        }
        return false;
    }

    static bool IsAllDigits(string phoneNumber)
    {
        foreach (char character in phoneNumber)
        {
            if (!char.IsDigit(character))
            {
                return false; 
            }
        }
        return true; 
    }
}
