using System.Collections.Generic;

namespace JuanMCillerLibrary
{
    public class WhileLoop
    {
        private WhileLoop()
        {
            
        }
        /// <summary>
        /// Method to print even and odd numbers.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns>List with all the odd and even numbers</returns>
        // Method to print even and odd numbers up to a specified limit
        public static List<string> PrintEvenNumbers(int limit)
        {
            // List to store results
            List<string> results = new List<string>();

            // Initialize counter
            int i = 1;

            // While loop to iterate up to the limit
            while (i <= limit)
            {
                // Check if the current number is even
                if (i % 2 == 0)
                {
                    // Add result to the list indicating that the number is even
                    results.Add($"{i} is even and lower than the {limit} limit");
                }
                else
                {
                    // Add result to the list indicating that the number is not even
                    results.Add($"{i} is not even and lower than the {limit} limit");
                }

                // Increment counter
                i++;
            }

            // Return the list of results
            return results;
        }
    }
}
