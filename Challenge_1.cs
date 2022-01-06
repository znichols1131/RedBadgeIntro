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
            // Get list of strings
            List<string> inputs = new List<string>() { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };

            // Set up output list
            List<string> outputs = new List<string>();

            // Filter using LINQ to remove not just duplicates but their pairs (i.e abc, abc, xyz => xyz)
            outputs = inputs.GroupBy(i => i)
                            .Where(o => o.Count() == 1)
                            .Select(o => o.Key)
                            .ToList();

            // Output
            Console.WriteLine("Inputs: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach(string input in inputs)
            {
                Console.WriteLine(input);
            }

            Console.WriteLine("\nOutputs: ");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string output in outputs)
            {
                Console.WriteLine(output);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
