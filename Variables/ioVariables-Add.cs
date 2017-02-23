//Adding numbers together, February 23rd, 2017.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Integer 1?: ");
            int int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Integer 2?: ");
            int int2 = Convert.ToInt32(Console.ReadLine());

            int intTotal = int1 + int2;
            Console.WriteLine(intTotal);
            Console.ReadLine();

        }
    }
}
