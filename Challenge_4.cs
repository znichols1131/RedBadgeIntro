using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeIntroChallenges
{
    public class Challenge_4
    {
        public void Run()
        {
            int[] setOne = { 1, 2, 3};
            int[] setTwo = { 4, 5, 6 };

            int[] setThree = { 7, -9, 3, -5 };
            int[] setFour = { 9, 1, 0, -4 };

            int intResult2 = 0;
            int intResult1 = 0;

            for (int i = 0; i < setOne.Count(); i++)
            {
                int product1 = setOne[i] * setTwo[i];
                intResult1 = intResult1 + product1;
            }

            for (int i = 0; i < setThree.Count(); i++)
            {
                int product2 = setThree[i] * setFour[i];
                intResult2 = intResult2 + product2;
            }

            Console.WriteLine(intResult1);
            Console.WriteLine(intResult2);
            Console.ReadLine();
        }
    }