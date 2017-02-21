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
    }
}
