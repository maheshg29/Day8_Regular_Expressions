﻿using System;
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
            Console.WriteLine("Select one Option for \n 1. Write a C# program that matches a string that has an ‘a’ followed by two to three 'b'\n" +
                " 2. Write a C# program to find sequences of lowercase letters joined by an underscore\n" +
                " 3. Write a Regular expression to fetch all HTML tags from a given string.\n" +
                " 4. Count the number of occurrences of the pattern in a given string.\n" +
                " 5. Use Regular expression to find valid file names with an image file type extension.\n" +
                " 6. Use Regular expression to validate a website address format.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Pattern.Question1("mahesh abb Gangurde");
                    break;

                case 2:
                    Pattern.Question2("Tree_plantation is very necessary because trees provide_oxygen to the environment and make the air_quality better");
                        break;

                case 3:
                    Pattern.Question3("<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>");
                    break;

                case 4:
                    Pattern.Question4("foxes are omnivorous mammals belonging to several genera of the family Canidae fox ");
                    break;

                case 5:
                    Pattern.Question5("img.jpeg img1.gif img2.png img3.jpg img4.mp3 img5.mp4");
                    break;

                case 6:
                    Pattern.Question6("https://www. https://www.mahesh.com");
                    break;


                default:
                    Console.WriteLine("Please Select Correct option");
                    break;
            }
        }
    }
}
