using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeIntroChallenges
{
    public class Challenge_3
    {
        public void Run()
        {
            Console.Clear();

            //// Get user input
            //Console.WriteLine("Enter any string for challenge 3: ");
            //string input = Console.ReadLine();
            string input = "Alfa Beta gamma";

            //// Split string by spaces
            string[] inputs = input.Trim().Split(' ');

            // Create an output string, edit strings before adding
            string output = "";
            foreach (string s in inputs)
            {
                // Check if the first letter was originally lowercase
                if(s.ToLower()[0] == s[0])
                {
                    // Make sure the string wasn't one character long (if so, ignore)
                    if(s.Length > 1)
                    {
                        output += $"{s.Substring(1, s.Length-1)} ";
                    }
                }
                else
                {
                    output += $"{s} ";
                }
            }

            // Trim any white spaces at thend
            output = output.Trim();

            // Print output
            Console.WriteLine("Formatted output: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(output);
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
