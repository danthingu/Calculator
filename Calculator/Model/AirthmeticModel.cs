using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// This is the model class for Calculator
    /// </summary>
    class AirthmeticModel
    {
        private double Result;
        private double tempNumber;
        /// <summary>
        /// Constructor
        /// </summary>
        public AirthmeticModel()
        {
            Result = 0;
            tempNumber = 1;
        }
        /// <summary>
        /// Returns the result
        /// </summary>
        public double Number
        {
            get { return Result;}
            set{Result = value;}

        }
       /// <summary>
       /// Add
       /// </summary>
       /// <param name="x">first number</param>
       /// <param name="y">Second number</param>
       /// <returns>result</returns>
        public double add(double x, double y)
        { return x + y; }

        /// <summary>
        /// Subtract
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <returns>result</returns>
        public double subtract(double x, double y)
        { return x - y; }

        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <returns>result</returns>
        public double Multiply(double x, double y)
        { return x * y; }

        /// <summary>
        /// Divide
        /// </summary>
        /// <param name="x">first number</param>
        /// <param name="y">second number</param>
        /// <returns>result</returns>
        public double Divide(double x, double y)
        { return x / y; }

    }
}
