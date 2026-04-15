using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBuildTest
{
    /// <summary>
    /// A silly addition class 
    /// </summary>
    public static class Addition
    {
        /// <summary>
        /// The AddTwoIntegers method takes two integers and returns their sum.
        /// </summary>
        /// <param name="number1">the first integer number to add</param>
        /// <param name="number2">the second integer number to add</param>
        /// <returns>The result of adding the two integers together</returns>
        public static int AddTwoIntegers(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
