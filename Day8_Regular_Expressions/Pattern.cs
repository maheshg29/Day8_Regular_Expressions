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
        public static void Question2(string inputString)
        {
            Regex regex = new Regex(@"[a-zA-Z]+_[a-zA-Z]+");

            MatchCollection matches = regex.Matches(inputString);

            Console.WriteLine("The input string '{0}' contains {1} matches:", inputString, matches.Count);

            foreach (Match match in matches)
            {
                Console.WriteLine("  Match: '{0}'", match.Value);
            }
        }

        public static void Question3(string inputString)
        {
            Regex regex = new Regex(@"<[^>]+>");

            MatchCollection matches = regex.Matches(inputString);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Question4(string inputString)
        {
            Regex regex = new Regex(@"fox(es)?");

            MatchCollection matches = regex.Matches(inputString);
            Console.WriteLine("The Count of given Pattern in given String "+matches.Count);
            
        }
    }

}


