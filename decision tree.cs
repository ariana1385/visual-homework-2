using System;

class HangoutDecisionTree
{
    static void Main()
    {
        Console.WriteLine("the Hangout Decision Tree!");

        if (!GetYesOrNoResponse("Are you in the mood to hang out with friends?"))
        {
            Console.WriteLine("That's okay! You can relax and enjoy some alone time.");
            return;
        }

        if (!GetYesOrNoResponse("Do you have time to hang out today?"))
        {
            Console.WriteLine("You can plan to hang out when you're free.");
            return;
        }

        if (!GetYesOrNoResponse("Do you have any plans with your friends?"))
        {
            Console.WriteLine("Consider reaching out to your friends to make some plans!");
            return;
        }

        if (!GetYesOrNoResponse("Is the location convenient for you?"))
        {
            Console.WriteLine("You might want to suggest a different location that works for everyone.");
            return;
        }

        Console.WriteLine("Great! It sounds like you should go hang out with your friends and have fun!");
    }

    static bool GetYesOrNoResponse(string question)
    {
        while (true)
        {
            Console.Write($"{question} (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                return true;
            }
            else if (response =="no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please answer with yes or no.");
            }
        }
    }
}
