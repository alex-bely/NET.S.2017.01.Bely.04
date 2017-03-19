using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task4;

namespace Task4.NUnitTests
{
    [TestFixture]
    public class MathOperationsTests
    {
        [TestCase(9, 2, 0.00001,ExpectedResult = 3)]
        [TestCase(438976,3, 0.00000000000001, ExpectedResult = 76)]
        [TestCase(2565.726409, 6, 0.00000000001, ExpectedResult = 3.7)]
        [TestCase(0.015625, 3, 0.0000001, ExpectedResult = 0.25)]
        [TestCase(2485.611295336, 3, 0.00001, ExpectedResult = 13.546)]

        public double NewtonNthRoot_RealNumberIntegerRootDegreeRealEpsilon_PositiveTest(double number, int rootDegree, double epsilon)
        {
            return MathOperations.NewtonNthRoot(number, rootDegree, epsilon);
        }



        [TestCase(27, -3,0.0001)]
        [TestCase(-2565.726409, 6, 0.00000000001)]
        [TestCase(0.015625, 0, 0.0000001)]
        public void NewtonNthRoot_NegativeRootDegreeOrEvenRootDegreeForNegativeNumber_ThrowsArgumentException(double number, int rootDegree, double epsilon)
        {
            Assert.Throws<ArgumentException>(() => MathOperations.NewtonNthRoot(number, rootDegree, epsilon));
        }
    }
}
