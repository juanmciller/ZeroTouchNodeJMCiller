using System.Collections.Generic;

namespace JuanMCillerLibrary
{
    public class BreakContinue
    {
        // Constructor for the BreakContinue class
        private BreakContinue()
        {
            // Constructor body (empty in this case)
        }

        /// <summary>
        /// This method filters odd numbers from the list.
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>List with odd numbers</returns>
        public static List<string> FilteringOddNumbers(List<int> numbers)
        {
            // Create a new list to store filtered results
            var result = new List<string>();

            // Loop through each number in the input list
            foreach (var number in numbers)
            {
                // Check if the current number is 0
                if (number == 0)
                {
                    // If the number is 0, add a message to the result list and terminate the loop
                    result.Add("Encountered 0. Terminating loop.");
                    break; // Terminates the loop
                }

                // Check if the current number is odd
                if (number % 2 != 0)
                {
                    // If the number is odd, add a message to the result list and skip to the next iteration
                    result.Add($"Skipping odd number: {number}");
                    continue; // Skips the current iteration and moves to the next one
                }
            }

            // Return the list containing filtered results
            return result;
        }
    }
}
