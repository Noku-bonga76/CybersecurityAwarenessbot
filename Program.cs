using CybersecurityAwarenessbot;
using CyberSecurityAwarenessbot;
using System;

namespace CyberSecurityAwarenessBot
{
    class Program
    {
        static void Main()
        {
            AudioPlayer.PlayGreeting();
            UIHelper.DisplayLogo();

            Chatbot bot = new();
            bot.StartChat();
        }
    }
}
