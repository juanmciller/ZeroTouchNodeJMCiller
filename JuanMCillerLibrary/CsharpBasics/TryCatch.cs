using System;
using System.Collections.Generic;

namespace JuanMCillerLibrary
{
    public class TryCatch
    {
        private TryCatch()
        {
            // Private constructor prevents instantiation of this class from outside
        }
        /// <summary>
        /// Method to check if a list of names contains "Juan" and generate a result for each name.
        /// </summary>
        /// <param name="names">List of names to be checked</param>
        /// <returns>List of strings containing the result for each name</returns>
        public static List<string> CatchJuan(List<string> names)
        {
            var result = new List<string>(); // List to store results for each name
            foreach (var name in names)
            {
                if (name == "Juan")
                {
                    // If the name is "Juan", throw an exception indicating Juan is not allowed to play the game
                    throw new Exception("Juan is not allowed to play the game!");
                }
                else
                {
                    // If the name is not "Juan", add a message indicating the name is allowed to play the game
                    result.Add($"{name} is allowed to play the game");
                }
            }
            return result; // Return the list of results
        }
        /// <summary>
        /// Performs division operation on two input numbers and returns the result as a string.
        /// </summary>
        /// <param name="input1">The first input number.</param>
        /// <param name="input2">The second input number.</param>
        /// <returns>A string containing the result of the division operation or an error message.</returns>
        public static string Division(int input1 = 1, int input2 = 1)
        {
            try
            {
                // Attempting division operation
                var result = input1 / input2;
                return $"Result: {result}"; // Returning the result as a formatted string
            }
            catch (DivideByZeroException ex)
            {
                // Handling the case where the second input is zero
                return $"Cannot divide {input1} with {input2}.";
            }
            catch (Exception ex)
            {
                // Catching any other unexpected exceptions
                return $"Unexpected error: " + ex.Message;
            }
        }
    }
}
