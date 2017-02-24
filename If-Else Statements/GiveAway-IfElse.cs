//Learning how to use reuse strings, and if statements. February 21st, 2017.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Cailen's Curtain Game");
            Console.Write("Curtain 1, 2, or 3?: ");
            string usersChoice = Console.ReadLine();

            string message = "";

            if (usersChoice == "1")
                message = "You win a new car!";
            else if (usersChoice == "2")
                message = "You don't win anything!";
            else if (usersChoice == "3")
                message = "You win... nothing, loser!";
            else
                message = "I don't understand.";

            Console.WriteLine(message);
            Console.ReadLine();
            */

            //The code is more corectly written below.
            Console.WriteLine("Cailen's Big Giveaway");
            Console.WriteLine("Please select curtain 1, 2, or 3.");
            Console.Write("Your selection is?: ");
            string userChoice = Console.ReadLine();
            string message = (userChoice == "1") ? "a brand new car!" : "nothing because you are a loser.";

            Console.WriteLine("Your choice was {0}, therefore you win {1}", userChoice, message);
            Console.ReadLine();
        }
    }
}
