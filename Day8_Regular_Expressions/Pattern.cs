using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8_Regular_Expressions
{
    public class Pattern
    {
        public static void Question1(string inputString)
        {
            Regex regex = new Regex(@"a[b]{2,3}");

            if (regex.IsMatch(inputString))
            {
                Console.WriteLine("The input string '{0}' matches the pattern.", inputString);
            }
            else
            {
                Console.WriteLine("The input string '{0}' does not match the pattern.", inputString);
            }
        }

    }

}


