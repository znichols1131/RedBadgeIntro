using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RedBadgeIntroChallenges
{
    public class Challenge_2
    {
        public void Run()
        {
            Console.Clear();
            string firstString = "She is nice.";
            string secondString = "true 222.";

            Console.WriteLine("Input: " + firstString);
            Console.WriteLine("Result: " + LettersOnly(firstString));

            Console.WriteLine("\nInput: " + secondString);
            Console.WriteLine("Result: " + LettersOnly(secondString));

            Console.ReadLine();
        }

        public bool LettersOnly(string input)
        {
            Regex regex1 = new Regex("[A-Z][a-z]");
            Regex regex2 = new Regex(".$");
            return (regex1.IsMatch(input) && regex2.IsMatch(input));
        }
    }
}
