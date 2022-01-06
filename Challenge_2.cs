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
        public bool LettersOnly(string input)
        {
            Regex regex1 = new Regex("[A-Z][a-z]");
            Regex regex2 = new Regex(".$");
            return (regex1.IsMatch(input) && regex2.IsMatch(input));
        }
    }
}
