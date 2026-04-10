using System;
using System.Collections.Generic;

namespace CybersecurityAwarenessbot
{
    public static class Responses
    {
        public static string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm just a bot, but I'm here to keep you safe online!";

            if (input.Contains("purpose"))
                return "My purpose is to educate you about cybersecurity.";

            if (input.Contains("ask"))
                return "You can ask me about passwords, phishing, and safe browsing.";

            if (input.Contains("password"))
                return "Use strong, unique passwords and never share them.";

            if (input.Contains("phishing"))
                return "Phishing is a cyberattack method  where attackers use deceptive tricks to trick people into sharing sensitive information such as passwords, banking details, or personal data." +
                    "It uses fake emails, text messages, calls, or websites. ";

            if (input.Contains("browsing"))
                return "Only visit secure websites (https) and avoid unknown links.";

            return "I didn’t quite understand that. Could you rephrase?";
        }
    }
}