using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 8 Practice Problem for Regular Expressions");
            Console.WriteLine("Select one Option for \n 1. Write a C# program that matches a string that has an ‘a’ followed by two to three 'b'");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Pattern.Question1("mahesh ab Gangurde");
                    break;

                default:
                    Console.WriteLine("Please Select Correct option");
                    break;
            }
        }
    }
}
