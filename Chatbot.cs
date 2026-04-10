using CyberSecurityAwarenessbot;
using System;

namespace CybersecurityAwarenessbot
{
    public class Chatbot
    {
        private string? userName;

        public void StartChat()
        {
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Enter your name: ");
                userName = Console.ReadLine();
            }

            UIHelper.TypingEffect($"Hello {userName}! Welcome to the Cybersecurity Awareness Bot.");

            string input = "";

            while (input != "exit")
            {
                Console.Write("\nYou: ");
                input = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(" Please enter something.");
                    continue;
                }

                string response = Responses.GetResponse(input);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Bot: ");
                Console.ResetColor();

                UIHelper.TypingEffect(response);
            }

            Console.WriteLine("Goodbye! Stay safe online.");
        }
    }
}