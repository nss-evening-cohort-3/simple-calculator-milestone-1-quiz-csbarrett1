using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class StackBuilder
    {
        public string LastInput = "Nothing asked to be calculated yet.";
        public string LastOutput = "Nothing output yet.";

        public void SetLastInput(string user_input)
        {
            LastInput = user_input;
        }
        public void SetLastOutput(string last_output)
        {
            LastOutput = last_output;
        }
    }
}
