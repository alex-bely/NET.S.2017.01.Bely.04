using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task3;

namespace Task3.NUnitTests
{
    [TestFixture]
    public class IntOperationsTests
    {

        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        [TestCase(8, ExpectedResult = -1)]
        [TestCase(1, ExpectedResult = -1)]
        

        public int NextBiggerNumber_PositiveIntegerNumber_PositiveTest(int number)
        {
            return IntOperations.NextBiggerNumber(number);
        }

        
        [TestCase(0)]
        [TestCase(-8)]
        [TestCase(int.MinValue)]

        public void NextBiggerNumber_NegativeOrZeroNumber_ThrowsArgumentOutOfRangeException(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => IntOperations.NextBiggerNumber(number));
        }

        [TestCase(int.MaxValue)]
        [TestCase(int.MaxValue-5)]
        [TestCase(int.MaxValue-75)]


        public void NextBiggerNumber_AlmostBiggestIntegerNumbers_ThrowsOverFlowException(int number)
        {
            Assert.Throws<OverflowException>(() => IntOperations.NextBiggerNumber(number));
        }

    }
}
