using System;
using System.Media;
using System.Runtime.InteropServices;

namespace CyberSecurityAwarenessbot
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                try
                {
                    SoundPlayer player = new("Greeting.wav");
                    player.PlaySync();
                }
                catch
                {
                    Console.WriteLine("Audio file not found.");
                }
            }
            else
            {
                Console.WriteLine("Audio not supported on this OS.");
            }
        }
    }
}