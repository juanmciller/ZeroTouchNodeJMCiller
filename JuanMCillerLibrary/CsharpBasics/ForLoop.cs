using System.Collections.Generic;

namespace JuanMCillerLibrary
{
    public class ForLoop
    {
        /// <summary>
        /// Compare a list of numbers with a target.
        /// </summary>
        /// <param name="numbers">Numbers to compare with a target.</param>
        /// <param name="target">Target value.</param>
        /// <returns>A list of strings describing the comparison results.</returns>
        public static List<string> CompareWithTarget(List<double> numbers, double target)
        {
            // Create a list to store the comparison results
            List<string> result = new List<string>();

            // Iterate through each number in the list
            foreach (double number in numbers)
            {
                // Checking if the number is equal to the target or half of the target
                if (number == target || number == target / 2)
                {
                    // Add a message to the result list indicating that the number is equal to the target or half of the target
                    result.Add($"{number} is equal to {target} or half of {target}");
                }
                // Checking if the number is not equal to the target
                else if (number != target)
                {
                    // Add a message to the result list indicating that the number is not equal to the target
                    result.Add($"{number} is not equal to {target}");
                }
                // If none of the conditions are met
                else
                {
                    // Add a message to the result list indicating that none of the conditions are met for the number
                    result.Add($"None of the conditions met for {number}");
                }
            }

            // Return the list of comparison results
            return result;
        }
    }
}
