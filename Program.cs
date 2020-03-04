using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalSkillsMentorship
{
    class Program
    {
        static void Main(string[] args)
        {
            // _2_FindFactorial
            Console.WriteLine("_2_FindFactorial");
            var factorial = new _2_FindFactorial();
            Console.WriteLine($"Factorial 0: {factorial.Factorial(0)}");
            Console.WriteLine($"Factorial 1: {factorial.Factorial(1)}");
            Console.WriteLine($"Factorial 2: {factorial.Factorial(2)}");
            Console.WriteLine($"Factorial 5: {factorial.Factorial(5)}");
            Console.WriteLine($"Factorial 12: {factorial.Factorial(12)}");

            Console.WriteLine("\n\n");

            // _2_FindFactorial (No Recursion)
            Console.WriteLine("_2_FindFactorial (No Recursion)");
            var factorialNoRecursion = new _2_FindFactorial();
            Console.WriteLine($"Factorial 0: {factorialNoRecursion.FactorialNoRecursion(0)}");
            Console.WriteLine($"Factorial 1: {factorialNoRecursion.FactorialNoRecursion(1)}");
            Console.WriteLine($"Factorial 2: {factorialNoRecursion.FactorialNoRecursion(2)}");
            Console.WriteLine($"Factorial 5: {factorialNoRecursion.FactorialNoRecursion(5)}");
            Console.WriteLine($"Factorial 12: {factorialNoRecursion.FactorialNoRecursion(12)}");

            Console.WriteLine("\n\n");

            // _1_AddDigitsUntilSingle
            Console.WriteLine("_1_AddDigitsUntilSingle");
            var singleTotal = new _1_AddDigitsUntilSingle();
            Console.WriteLine($"Result: {singleTotal.SingleTotal(38)}\n");
            Console.WriteLine($"Result: {singleTotal.SingleTotal(1112)}\n");
            Console.WriteLine($"Result: {singleTotal.SingleTotal(483647)}\n");

        } // Main method

    } // Program class

} // TechnicalSkillsMentorship namespace
