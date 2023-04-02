using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public static string imageRegex = "^[a-zA-Z0-9]+\\.(jpg|jpeg|png|gif)$";
        public static void Question5(string inputString)
        {
            string[] words=inputString.Split(' ');
            
            foreach (string word in words)
            {
                if (Regex.IsMatch(word,imageRegex))
                {
                    Console.WriteLine("{0} is a valid image file name ",word);
                }
                else
                {
                    Console.WriteLine("{0} is a Invalid image file name ",word);
                }              
            }  
        }
        public static string webAddressRegex = "^(http:|https:)\\/\\/([w]{3}\\.)[a-zA-Z0-9]+\\.{1}[a-z]{2,3}$";
        public static void Question6(string inputString)
        {
            string[] words = inputString.Split(' ');

            foreach (string word in words)
            {
                if (Regex.IsMatch(word, webAddressRegex))
                {
                    Console.WriteLine("{0} is a valid Web Address ", word);
                }
                else
                {
                    Console.WriteLine("{0} is a Invalid Web Address ", word);
                }
            }
        }
    }

}


