using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyber_Security_Bot
{
    internal class Cyber_Bot
    {
        public string UserName { get; set; }
        public void PlayVoiceGreeting()

        {

            try

            {

                // System.Media is the built-in Windows library for sound

                System.Media.SoundPlayer player = new System.Media.SoundPlayer("greeting.wav");

                // Play() runs the sound in the background so the console doesn't freeze

                player.Play();

            }

            catch (Exception ex)

            {

                // This stops the program from crashing if they forgot the "Copy if newer" step

                Console.WriteLine("Audio file not found: " + ex.Message);

            }

        }

        public void ShowGreeting()
        {
            // Task 6: Enhanced UI (Colours)
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Task 2: ASCII Art Logo (Use the @ symbol for verbatim strings!)
            Console.WriteLine("        ╔════════════╗");
            Console.WriteLine("        ║  ◉     ◉   ║");
            Console.WriteLine("        ║     ⌁      |");
            Console.WriteLine("        ║   \\___/    ║");
            Console.WriteLine("        ╚════════════╝");
            Console.WriteLine("     [ AI SECURITY CORE ]");
            // Reset color back to normal
            Console.ResetColor();

            Console.WriteLine("==================================================");
            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("==================================================");
            Console.WriteLine(); // Blank line for spacing

            // Task 3: Ask for the user's name
            Console.Write("To get started, what is your name? ");
            // Store the input in our Automatic Property
            UserName = Console.ReadLine();

            // Personalise the response
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nHello," + UserName + "! It is great to meet you.");
            Console.ResetColor();
        }

    }
}
