using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Provides additional method for handling with integer numbers
    /// </summary>
    public static class IntOperations
    {
        #region Public method
        /// <summary>
        /// Returns the next higher integer with the same set of digits as the source number or - 1 if this number doesn't exist
        /// </summary>
        /// <param name="number">Positive integer number</param>
        /// <returns>The next higher integer with the same set of digits as the source number or - 1</returns>
        /// <exception cref="ArgumentOutOfRangeException">Argument is out of range</exception>
        public static int NextBiggerNumber(int number)
        {
            if (number < 1) throw new ArgumentOutOfRangeException();
            return NextBigNumber(number);

        }
        #endregion



        #region Private methods
        private static int NextBigNumber(int number)
        {
           


            int[] temp = new int[number.ToString().Length];
            for (int i = temp.Length - 1; i > -1; i--)
            {
                temp[i] = number % 10;
                number /= 10;
            }

            int pivot = -1;

            pivot = FindPivot(temp);

            if (pivot == -1) return -1;

            SortAfterPivot(pivot, temp);

            int result = 0;
            for (int i = 0; i < temp.Length; i++)
                result += (int)(temp[i] * Math.Pow(10, temp.Length - 1 - i));
            if (result < 0) throw new OverflowException();

            return result;

        }

        private static int FindPivot(int[] temp)
        {
            for (int i = temp.Length - 1; i > 0; i--)
            {
                if (temp[i] > temp[i - 1])
                {
                    return (i - 1);
                    
                }

            }
            return -1;
        }

        private static void SortAfterPivot(int pivot, int[] temp)
        {
            Array.Sort(temp, pivot + 1, temp.Length - pivot - 1);

            for (int i = pivot + 1; i < temp.Length; i++)
            {
                if (temp[i] > temp[pivot])
                {
                    int z = temp[i];
                    temp[i] = temp[pivot];
                    temp[pivot] = z;
                    break;

                }
            }

            Array.Sort(temp, pivot + 1, temp.Length - pivot - 1);
        }

        #endregion
    }
}
