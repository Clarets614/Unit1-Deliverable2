using System;
using System.Globalization;
using System.Security.Cryptography;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello there, What is your name?\n");

        string name = Console.ReadLine();

        Console.WriteLine("\nThat's a great name " + name + "! \n\n Would you like to play Clare's Coin Flip Challenge?\n");

        string answerInput = Console.ReadLine().ToLower();
        while (answerInput != "yes" && answerInput != "no")
        {
            Console.WriteLine("\n I cannot acknowledge that answer. Please answer yes or no");
            answerInput = Console.ReadLine().ToLower();
        }
        if (answerInput == "yes")
        {
            Console.WriteLine("\n Fantastic! Lets Play!");


            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Random coinflip = new Random();
                int randomNumber = coinflip.Next(0, 2);
                string result;


                if (randomNumber == 0)
                {
                    result = "heads";

                }
                else
                {
                    result = "tails";
                }
                Console.WriteLine("\n Flip a coin, heads or tails?");
                string userInput = Console.ReadLine().ToLower();

                while (userInput != "heads" && userInput != "tails")
                {
                    Console.WriteLine("\n Invalid Answer, Please answer heads or tails");
                    userInput = Console.ReadLine().ToLower();
                }
                if (result == userInput)
                {
                    Console.WriteLine("\n The coin has flipped to " + result + "! You have won this one " + name + "!", score++);
                }
                else
                {
                    Console.WriteLine("\n The coin has flipped to " + result + "! You are incorrect, " + name + ", and you lose.");
                }


            }
            Console.WriteLine("\n Thanks " + name + ", your score is " + score);
            Console.WriteLine("\n Thank you for playing Clare's Coin Challenge! It has been a pleasure flipping coins with you!");




        }
        else
        {
            Console.WriteLine("I did not take you for a Coward, " + name + ". Very well then.\n Goodbye!");
        }

    }
}