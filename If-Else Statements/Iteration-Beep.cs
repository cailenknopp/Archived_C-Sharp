//This will play one thousand beeps. February 21st, 2017.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Beep(600, 200);
                Console.WriteLine("Beep #" + i);
            }
            Console.ReadLine();
        }
    }
}
