//Working with strings, February 20th, 2017.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            Console.Write("Your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.Write("Your last name: ");
            string myLastName;
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName +".");
            Console.ReadLine();
            
             // Declaring today as the variable "CurrentDay"
            DateTime CurrentDay = DateTime.Today;

            //Writing a string using the user's first name, and telling the day of the week and date. 
            Console.WriteLine($"Guess what {myFirstName}? Today is {(CurrentDay.ToString("D"))}.");
            Console.ReadLine();
        }
    }
}
