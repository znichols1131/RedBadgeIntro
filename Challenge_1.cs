using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeIntroChallenges
{
    public class Challenge_1
    {
        public void Run(List<string> input)
        {
            List<string> result = input
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .SelectMany(x => x)
                .ToList();

            Console.WriteLine(result);
        }
    }
}
