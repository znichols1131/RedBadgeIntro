using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeIntroChallenges
{
    public class Challenge_1
    {
        public void Run()
        {
            // Get user input
            Console.WriteLine("Enter any string for challenge 3: ");
            string input = Console.ReadLine();

            // Split string by spaces
            string[] inputs = input.Trim().Split(' ');

            List<string> result = inputs
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .SelectMany(x => x)
                .ToList();

            Console.WriteLine(result);
        }
    }
}
