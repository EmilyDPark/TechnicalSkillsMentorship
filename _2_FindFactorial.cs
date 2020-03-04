using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalSkillsMentorship
{
    class _2_FindFactorial
    {
        // March 4, 2020

        // Given a positive integer n, find the factorial of n.

        // Example 1: 
        // Input: n = 0
        // Output: 1

        // Example 2: 
        // Input: n = 1
        // Output: 1

        // Example 3: 
        // Input: n = 2
        // Output: 2

        // Example 4: 
        // Input: n = 5
        // Output: 120
        // Explanation: 5 * 4 * 3 * 2 * 1 = 120

        // Constraints:
        //  - 0 <= n

        public int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            if (n < 0)
                throw new ArgumentOutOfRangeException();

            n *= Factorial(n - 1);

            return n;

        } // Factorial method

        public int FactorialNoRecursion(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            if (n < 0)
                throw new ArgumentOutOfRangeException();

            int prod = n;

            for (int i = 2; i < n; i++)
                prod *= i;

            return prod;

        } // FactorialNoRecursion method

    } // FindFactorial class

} // TechnicalSkillsMentorship namespace
