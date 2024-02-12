using System;

namespace JuanMCillerLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class MyFirstNode
    {
        private MyFirstNode()
        {
            
        }
        /// <summary>
        /// This is our first method to retrieve the Data Type of an input.
        /// </summary>
        /// <param name="myVariable">This variable can be whatever input data type.</param>
        /// <returns>A C# Data type</returns>
        public static Type GetDataType(object myVariable)
        {
            return myVariable.GetType();
        }
    }
}
