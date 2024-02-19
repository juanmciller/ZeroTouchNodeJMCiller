using System;
using System.Collections.Generic;

namespace JuanMCillerLibrary
{
    // Namespace declaration for the library
    public class IFStatement
    {
        /// <summary>
        /// Method to get the average of a 3-test exam.
        /// </summary>
        /// <param name="student">Name of the student.</param>
        /// <param name="testA">First mark.</param>
        /// <param name="testB">Second mark.</param>
        /// <param name="testC">Third mark.</param>
        /// <returns>Result of the exam.</returns>
        public static string GetTestResult(string student, double testA, double testB, double testC)
        {
            // Variable to store the average
            double average;
            // Calculating the average of the three tests
            average = (testA + testB + testC) / 3;
            // Checking if the average is less than 5
            if (average < 5.00)
            {
                // If the average is less than 5, the student failed the exam
                return $"{student} failed the exam with a mark of {average} average";
            }
            // Checking if the average is exactly 5
            else if (average == 5.00)
            {
                // If the average is exactly 5, the student needs to repeat the exam
                return $"{student} has to repeat the exam with a mark of {average} average";
            }
            // If the average is greater than 5
            else
            {
                // If the average is greater than 5, the student passed the exam
                return $"{student} passed the exam with a mark of {average} average";
            }
        }
        

    }
}
