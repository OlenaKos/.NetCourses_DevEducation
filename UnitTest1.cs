using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void math1X_entered_8_returned0_125()
        {
            double num = 8;
            double expected = 0.125;
            double actual = MyMath.math1X(num);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void mathCube_entered_8_returned512()
        {
            double num = 8;
            double expected = 512;
            double actual = MyMath.mathCube(num);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void mathSquare_entered_8_returned64()
        {
            double num = 8;
            double expected = 64;
            double actual = MyMath.mathSquare(num);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void mathSqrt_entered9_returned3()
        {
            double num = 9;
            double expected = 3;
            double actual = MyMath.mathSqrt(num);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void mathPercent_entered9_3_returned0_27()
        {
            double num1 = 9;
            double num2 = 3;
            double expected = 0.27;

            double actual = MyMath.mathPercent(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void mathAddition_entered5_125_returned130()
        {
            double num1 = 5;
            double num2 = 125;
            double expected = 130;

            double actual = MyMath.mathAddition(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void mathSubtraction_entered302_23_returned279()
        {
            double num1 = 302;
            double num2 = 23;
            double expected = 279;
            double actual = MyMath.mathSubtraction(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void mathMultiplication_entered_4_7_returned_28()
        {
            double num1 = 4;
            double num2 = 7;
            double expected = 28;
            double actual = MyMath.mathMultiplication(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void mathDivision_entered_9_3_received_3()
        {
            double num1 = 9;
            double num2 = 3;
            double expected = 3;
            double actual = MyMath.mathDivision(num1, num2);

            Assert.AreEqual(expected, actual);
        }
    }
}
