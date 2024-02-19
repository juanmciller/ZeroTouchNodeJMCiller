using Autodesk.DesignScript.Runtime;
using System.Collections.Generic;

namespace JuanMCillerLibrary
{
    /// <summary>
    /// This is my Numbers class.
    /// </summary>
    public class Numbers
    {
        private Numbers()
        {
            // Private constructor to prevent instantiation of this class.
        }

        /// <summary>
        /// This node executes the sum and product of two values.
        /// </summary>
        /// <param name="firstValue">First value of the math operation.</param>
        /// <param name="lastVAlue">Second value of the math operation.</param>
        /// <returns>Returns a dictionary containing the sum and product of the two input values.</returns>
        [MultiReturn(new[] { "add", "prod" })] // Indicates that the method will return multiple values (sum and product).
        public static Dictionary<string, object> ReturnMathOperation(double firstValue, double lastVAlue)
        {
            // Creating a dictionary to store the result of the math operations.
            return new Dictionary<string, object>
            {
                // Adding the sum of the two input values to the dictionary.
                { "add", (firstValue + lastVAlue) },
                // Adding the product of the two input values to the dictionary.
                { "prod", (firstValue * lastVAlue) }
            };
        }
    }
}
