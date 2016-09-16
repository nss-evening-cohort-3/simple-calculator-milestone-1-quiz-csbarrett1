using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Math
    {
        public string Add(int firstTerm, int secondTerm)
        {
            return Convert.ToString(firstTerm + secondTerm);
        }
        public string Subtract(int firstTerm, int secondTerm)
        {
            return Convert.ToString(firstTerm - secondTerm);
        }
        public string Multiply(int firstTerm, int secondTerm)
        {
            return Convert.ToString(firstTerm * secondTerm);
        }
        public string Divide(int firstTerm, int secondTerm)
        {
            return Convert.ToString(firstTerm / secondTerm);
        }
        public string Modulo(int firstTerm, int secondTerm)
        {
            return Convert.ToString(firstTerm % secondTerm);
        }

    }
}
