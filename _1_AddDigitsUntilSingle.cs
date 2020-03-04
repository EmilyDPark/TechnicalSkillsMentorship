using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalSkillsMentorship
{
    class _1_AddDigitsUntilSingle
    {
        // February 19, 2020

        // Given an integer num, repeatedly add all its digits until the result has only one digit.

        // For example:
        // Given num = 38, the process is like: 3 + 8 = 11, 11 isn’t a single digit, so repeat, 1 + 1 = 2. 
        // Given num = 1112, the process is like 1 + 1 + 1 + 2 = 5, we stop at 5.
        // Since 2 has only one digit, return it.

        public int SingleTotal(int input)
        {
            int digit;
            int total = 0;
            int counter = 1;

            while (true)
            {
                Console.WriteLine($"Pass #{counter}: {input}");

                while (input > 0)
                {
                    digit = input % 10;
                    total += digit;
                    input /= 10;
                }

                if (total > 9)
                {
                    input = total;
                    total = 0;
                    counter++;
                    continue;
                }
                else
                {
                    break;
                }
            }
            return total;

        } // SingleTotal method

    } // AddDigitsUntilSingle class

} // TechnicalSkillsMentorship namespace
