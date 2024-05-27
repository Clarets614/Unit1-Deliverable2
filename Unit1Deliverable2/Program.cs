using System;
using System.Globalization;
using System.Security.Cryptography;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello there, What is your name?");

        string name = Console.ReadLine();

        Console.WriteLine($"That's a great name {name}!\nWould you like to play Clare's Coin Flip Challenge?");
        Console.WriteLine("Please answer yes or no:");

        string answerInput = Console.ReadLine().ToLower();
        while (answerInput != "yes" && answerInput != "no")
        {
            Console.WriteLine("I cannot acknowledge that answer. Please answer yes or no");
            answerInput = Console.ReadLine().ToLower();
        }
        if (answerInput == "yes")
        {
            Console.WriteLine("Fantastic! Lets Play!");
            Console.WriteLine("You will be able to flip the coin 5 times.");
            Console.WriteLine("How many tosses can you win?");


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
                Console.WriteLine("Flip a coin, heads or tails?");
                string userInput = Console.ReadLine().ToLower();
                Console.Write($"{i + 1}. ");

                while (userInput != "heads" && userInput != "tails")
                {
                    Console.WriteLine("Invalid Answer, Please answer heads or tails");
                    userInput = Console.ReadLine().ToLower();
                }
                if (result == userInput)
                {
                    
                    Console.WriteLine($"The coin has flipped to {result}! You have won this one {name}!", score++);
                }
                else
                {
                    Console.WriteLine($"The coin has flipped to {result}! I am sorry to say, {name} that you lose this one.");
                }


            }
            Console.WriteLine($"\n Thanks {name}, your score is {score}.");
            Console.WriteLine($"\n Thank you for playing Clare's Coin Challenge! It has been a pleasure flipping coins with you!");




        }
        else
        {
            Console.WriteLine($"I did not take you for a Coward, {name}. Very well then.\n Goodbye!");
        }

    }
}