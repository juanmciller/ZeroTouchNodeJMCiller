namespace CsharpBasics
{
    public class Strings
    {
        private Strings()
        {
            
        }
        /// <summary>
        /// This is a method to concatenate two strings.
        /// </summary>
        /// <param name="myString1">My first string input.</param>
        /// <param name="myString2">My second string input.</param>
        /// <returns>The result of merging two string inputs.</returns>
        public static string ConcatenateStrings(string myString1, string myString2)
        {
            return myString1 + myString2;
        }
        /// <summary>
        /// This code gets the length of a string.
        /// </summary>
        /// <param name="myString">String input.</param>
        /// <returns>Returns an integer.</returns>
        public static int GetStringLength(string myString)
        {
            return myString.Length;
        }
    }
}
