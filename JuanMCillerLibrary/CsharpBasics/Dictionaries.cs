using System;
using System.Collections.Generic;

namespace JuanMCillerLibrary
{
    /// <summary>
    /// Contains methods related to dictionaries.
    /// </summary>
    public class Dictionaries
    {
        // Private constructor to prevent instantiation of this class
        private Dictionaries()
        {
            // This constructor is empty
        }

        /// <summary>
        /// Creates a dictionary from arrays of keys and values.
        /// </summary>
        /// <param name="keys">Array of keys.</param>
        /// <param name="values">Array of values.</param>
        /// <returns>The dictionary containing the key-value pairs.</returns>
        public static Dictionary<string, object> CreateDictionary(string[] keys, object[] values)
        {
            // Check if the number of keys matches the number of values
            if (keys.Length != values.Length)
            {
                // If the number of keys doesn't match the number of values, throw an ArgumentException
                throw new ArgumentException("Number of keys must match number of values.");
            }

            // Create a new dictionary to store the key-value pairs
            var myDictionary = new Dictionary<string, object>();

            // Populate the dictionary with key-value pairs
            for (int i = 0; i < keys.Length; i++)
            {
                // Add each key-value pair to the dictionary
                myDictionary.Add(keys[i], values[i]);
            }

            // Return the populated dictionary
            return myDictionary;
        }
        /// <summary>
        /// Generates a list of messages indicating whether each person is allowed to enter the club based on their name and age.
        /// </summary>
        /// <param name="people">A list of dictionaries representing people with "Name" and "Age" keys.</param>
        /// <returns>A list of strings containing messages about whether each person is allowed to enter the club.</returns>
        public static List<string> GetListAllowedEntrants(List<Dictionary<string, object>> people)
        {
            // Initialize the list to store the output
            List<string> output = new List<string>();

            // Iterate over each person in the list
            foreach (var person in people)
            {
                // Check if the dictionary contains the "Name" key and the value is of type string
                if (person.ContainsKey("Name") && person["Name"] is string name)
                {
                    // Check if the dictionary contains the "Age" key
                    if (person.ContainsKey("Age"))
                    {
                        // Check if the value associated with the "Age" key is of type long
                        if (person["Age"] is long age)
                        {
                            // Cast the age to int
                            int ageCasted = (int)age;
                            // Check if the age is greater than or equal to 18
                            if (ageCasted >= 18)
                            {
                                // Add a message indicating the person can enter the club to the output list
                                output.Add($"{name} can get into the club. Their age is {ageCasted} years old or older.");
                            }
                            else
                            {
                                // Add a message indicating the person cannot enter the club to the output list
                                output.Add($"{name} CANNOT get into the club. Their age is less than 18 years old.");
                            }
                        }
                        else
                        {
                            // Add a message indicating that age information is not of type long to the output list
                            output.Add($"{name}'s age information is not of type long.");
                        }
                    }
                    else
                    {
                        // Add a message indicating that age information is missing to the output list
                        output.Add($"{name}'s age information is missing.");
                    }
                }
                else
                {
                    // Add a message indicating that name information is missing or invalid to the output list
                    output.Add("Name information is missing or invalid.");
                }
            }

            // Return the list of output messages
            return output;
        }
    }
}