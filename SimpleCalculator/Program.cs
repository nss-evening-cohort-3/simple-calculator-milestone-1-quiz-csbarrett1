using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StackBuilder stack = new StackBuilder();
            Expression exp = new Expression();
            Message message = new Message();
            bool keepGoing = true;
            int counter = 0;
            while (keepGoing == true)
            {
                string prompt = "[" + counter + "]> ";
                Console.Write(prompt);
                string input = Console.ReadLine().ToLower();
                counter += 1;
                if (input == "exit" | input == "quit")
                {
                    Console.WriteLine("Goodbye");
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("   = " + exp.ExpressionHandler(input));
                }
            }
        }
    }
}
