using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp98
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (counter <= 10)
            {
                Console.Write($"{ counter }");
                ++counter;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
