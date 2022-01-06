using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeIntroChallenges
{
    public class Challenge1
    {
        private readonly List<string> _input;

        public Challenge1(List<string> input)
        {
            _input = input;
        }
        public List<string> Solve()
        {
            List<string> result = _input
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .SelectMany(x => x)
                .ToList();

            return result;
        }
    }
}
