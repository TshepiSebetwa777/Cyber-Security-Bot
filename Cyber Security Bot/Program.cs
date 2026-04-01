using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyber_Security_Bot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the bot object

            Cyber_Bot myBot = new Cyber_Bot();



            // Call the greeting method
           
            myBot.PlayVoiceGreeting();
            myBot.ShowGreeting();
            myBot.StartChatting();


        }
    }
}
