namespace CsharpBasics
{
    public class Switch
    {
        private Switch()
        {
            
        }
        /// <summary>
        /// Method to outcome switch values.
        /// </summary>
        /// <param name="number">Number to be processed within the Switch statement.</param>
        /// <returns></returns>
        public static string SwitchStatement(int number)
        {
            switch (number)
            {
                case 1:
                    return "You entered one.";
                case 2:
                    return "You entered two.";
                case 3:
                    return "You entered three.";
                default:
                    return "Invalid input. Please enter a number between 1 and 3.";
            }
        }
    }
}
