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

        public void StartChatting()

        {

            Typewriter("\nYou can start asking me questions. Type 'exit' to leave the chat.");

            // 1. Set up the infinite loop so the bot keeps listening

            while (true)

            {

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write($"\n[{UserName}]: "); // Uses the name we saved earlier!

                Console.ResetColor();

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Typewriter("[Bot]: I didn't quite understand that. Could you rephrase?"); // Required phrase
                    Console.ResetColor();
                    continue; // This skips the rest of the loop and starts over at the top!
                }
                // Convert input to lowercase so it's easy to check

                input = input.ToLower();

                // Give the user a way to break the loop!

                if (input == "exit")

                {

                    Typewriter("[Bot]: Goodbye! Stay safe online.");

                    break; // This breaks us out of the while loop entirely

                }

                // Task 4: Respond to basic cybersecurity questions

                Console.ForegroundColor = ConsoleColor.Cyan;

                if (input.Contains("how are you"))

                {

                    Typewriter("[Bot]: I'm functioning perfectly, thank you! How can I help you secure your data today?");

                }

                else if (input.Contains("purpose"))

                {

                    Typewriter("[Bot]: My purpose is to spread cybersecurity awareness and help you protect your digital life.");

                }

                else if (input.Contains("what can i ask"))

                {

                    Typewriter("[Bot]: You can ask me about password safety, phishing, and safe browsing!");

                }

                else if (input.Contains("password"))

                {

                    Typewriter("[Bot]: Always use strong, unique passwords. A mix of uppercase, lowercase, numbers, and symbols is best.");

                }

                else if (input.Contains("phishing"))

                {

                    Typewriter("[Bot]: Phishing is when scammers try to trick you into revealing sensitive info. Don't click suspicious links!");

                }

                else if (input.Contains("safe browsing"))

                {

                    Typewriter("[Bot]: For safe browsing, ensure websites use HTTPS and avoid public Wi-Fi for banking.");

                }

                else

                {

                    // Task 5: Default response for unsupported queries

                    Typewriter("[Bot]: I didn't quite understand that. Could you rephrase?");

                }

                Console.ResetColor();

            }
         }

        public void Typewriter(string message)

        {

            // A foreach loop goes through the string one letter at a time

            foreach (char c in message)

            {

                Console.Write(c); // Notice this is Write, not WriteLine!

                // This pauses the program for 30 milliseconds between each letter

                System.Threading.Thread.Sleep(30);

            }

            // Once the whole sentence is typed, jump to the next line

            Console.WriteLine();

        }
    }
}
