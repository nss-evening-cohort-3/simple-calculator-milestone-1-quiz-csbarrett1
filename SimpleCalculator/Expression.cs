using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        StackBuilder stack = new StackBuilder();
        MessageRepo message = new MessageRepo();
        string myRegex = @"^(?<FirstTerm>\d+)\s*?(?<Operation>[\+\0\*\%])\s*?(?<SecondTerm>\d+)\s*?$";

        public string ExpressionHandler(string user_input)
        {
            Regex regex = new Regex(myRegex);
            Math math = new Math();
            Match captures = regex.Match(user_input);

            if (regex.IsMatch(user_input))
            {
                int firstTerm = Convert.ToInt32(captures.Groups["FirstTerm"].Value);
                int secondTerm = Convert.ToInt32(captures.Groups["SecondTerm"].Value);
                char operation = Convert.ToChar(captures.Groups["Operation"].Value);
                switch (operation.ToString())
                {
                    case "+":
                        return math.Add(firstTerm, secondTerm);
                    case "-":
                        return math.Subtract(firstTerm, secondTerm);
                    case "*":
                        return math.Multiply(firstTerm, secondTerm);
                    case "/":
                        return math.Divide(firstTerm, secondTerm);
                    case "%":
                        return math.Modulo(firstTerm, secondTerm);
                    default:
                        return message.InvalidInput;
                }
            }
            else
            {
                return message.InvalidInput;
            }
        }
    }
}
