/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Operators
{
    class Program
    {
        static void Main()
        {
            // ! expresses not, && expresses AND, || expresses OR.
            // In this scenario, we are wondering if we should use our umbrella outside or not.
            // If it is rainy OR sunny, we want to use our umbrella.
            // However, if it is windy, we do not want to use our umbrella at all.
            // If it is windy, the rest of the expression will not be checked, UseUmbrella will return false.
            bool UseUmbrella(bool rainy, bool sunny, bool windy)
            {
                // So, we will only use our umbrella if:
                // it is NOT(!) windy, AND(&&) it is rainy OR(||) sunny.
                return !windy && (rainy || sunny);
            }
            Console.WriteLine(UseUmbrella(true, true, true)); // False, because it is windy.
            Console.WriteLine(UseUmbrella(true, true, false)); // True, because it is not windy, and it is rainy and sunny.
            Console.WriteLine(UseUmbrella(false, true, false)); // True, because it is not windy, and it is sunny
            Console.WriteLine(UseUmbrella(true, false, false)); // True, because it is not windy, and it is rainy.
            // The Ternary Operator ? takes in three operands, and has the form of q ? a : b.
            // If condition q is true, a is evaluated. Else, b is evaluated.
            int Max (int a, int b)
            {
                // This function determines which number is largest.
                // if a is greater than b, 
                return (a > b) ? a : b;
            }
            Console.WriteLine(Max(80, 70)); // 80
            Console.WriteLine(Max(50, 90)); // 90
        }
    }
}
    
