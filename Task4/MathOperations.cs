using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /// <summary>
    /// Provides additional mathematical tools
    /// </summary>
    public static class MathOperations
    {
        #region Public method
        /// <summary>
        /// Returns the root of specified degree of the number
        /// </summary>
        /// <param name="number">Source number</param>
        /// <param name="rootDegree">Root degree</param>
        /// <param name="epsilon">Precision of calculations</param>
        /// <returns>Root of specified degree of the number</returns>
        /// <exception cref="ArgumenException">One of arguments is not valid</exception>
        public static double NewtonNthRoot(double number, int rootDegree, double epsilon)
        {
            if (rootDegree < 1) throw new ArgumentException();
            if (number < 0 && rootDegree % 2 == 0) throw new ArgumentException();
            
            return NewtonRoot(number, rootDegree, epsilon);
        }
        #endregion


        #region Private method
        private static double NewtonRoot(double number, int rootDegree, double epsilon)
        {
            double initialValue = number / rootDegree;
            double nextStepValue = (1.0 /rootDegree) * ((rootDegree - 1) * initialValue + number / Math.Pow(initialValue, rootDegree - 1));

            while (Math.Abs(nextStepValue - initialValue) > epsilon)
            {
                initialValue = nextStepValue;
                nextStepValue = (1.0 / rootDegree) * ((rootDegree - 1) * initialValue + number / Math.Pow(initialValue, rootDegree - 1));
            }
            return nextStepValue;

        }
        #endregion

    }
}
