using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            var i = 0;
            string prompt = ">";
            int counter = i;
            char[] operatorSymbols = { '+', '-', '/', '*', '%' };
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Write("[" + counter++ + "]" + prompt + " ");

                string equation = Convert.ToString(Console.ReadLine());

                string[] numbers = equation.Split(operatorSymbols);


                List<int> digits = new List<int>();
                foreach (string n in numbers)
                {
                    int digit = Int32.Parse(n);
                    digits.Add(digit);
                }

                if (digits.Count != 2)
                {
                    Console.WriteLine("YOU GOTTA PUT IN TWO NUMBERS!");
                }

                if (equation.Contains("+"))
                {
                    int answer = digits[0] + digits[1];
                    Console.WriteLine("   = " + answer);
                }
                else if (equation.Contains("-"))
                {
                    int answer = digits[0] - digits[1];
                    Console.WriteLine("   = " + answer);
                }
                else if (equation.Contains("/"))
                {
                    int answer = digits[0] / digits[1];
                    Console.WriteLine("   = " + answer);
                }
                else if (equation.Contains("*"))
                {
                    int answer = digits[0] * digits[1];
                    Console.WriteLine("   = " + answer);
                }
                else
                {
                    Console.WriteLine("WHAT AM I SUPPOSED TO DO WITH THAT?!");
                }
                








            }


            Console.ReadKey();
        }
    }
}
