using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculatorLib;


namespace calculatorTest


{
    [TestClass]
    public class UnitTest1
    {

        // [TestMethod]
        [DataTestMethod]
        [DataRow(4, 3, 7)]
        [DataRow(4, 4, 8)]
        [DataRow(4, 5, 9)]
        [DataRow(4, 6, 10)]
        [DataRow(4, 7, 11)]
        [DataRow(4, 8, 12)]
        [DataRow(4, 9, 13)]
        [DataRow(4, 10, 14)]
        [DataRow(4, 11, 15)]
        [DataRow(4, 12, 16)]
        [TestCategory("Addition")]

        public void CalculatorAddTestMethod1(double a, double b, double x)
        {

            double actual = Class1.Add(a, b);
            Assert.AreEqual(x, actual);
            // Class1 varCal = new Class1();
            //  double v = varCal.Add(a, b);
            // result = Calculator.add(1, 2);
            //Assert.AreEqual(expected, varCal);
        }

        // [TestMethod]
        [DataTestMethod]
        [DataRow(4, 3, 1)]
        [DataRow(4, 4, 0)]
        [DataRow(5, 4, 1)]
        [DataRow(6, 4, 2)]
        [DataRow(7, 4, 3)]
        [DataRow(8, 4, 4)]
        [DataRow(9, 4, 5)]
        [DataRow(10, 4, 6)]
        [DataRow(11, 4, 7)]
        [DataRow(12, 4, 8)]
        [TestCategory("Subtraction")]

        public void CalculatorSubtractionTestMethod1(double a, double b, double x)
        {

            double actual = Class1.Substract(a, b);
            Assert.AreEqual(x, actual);
        }

        [DataTestMethod]
        [DataRow(4, 3, 12)]
        [DataRow(5, 3, 15)]
        [DataRow(2, 3, 6)]
        [DataRow(3, 3, 9)]
        [DataRow(4, 3, 12)]
        [DataRow(6, 3, 18)]
        [DataRow(7, 3, 21)]
        [DataRow(8, 3, 24)]
        [DataRow(9, 3, 27)]
        [DataRow(10, 3, 30)]


        [TestCategory("Multiplication")]

        public void TestMethodSMultiplication(double a, double b, double x)
        {
            double actual = Class1.Multiply(a, b);
            Assert.AreEqual(x, actual);

        }

        [DataTestMethod]
        [DataRow(10, 2, 5)]
        [DataRow(25, 5, 5)]
        [DataRow(30, 5, 6)]
        [DataRow(2, 2, 1)]
        [DataRow(100, 4, 25)]
        [DataRow(4, 2, 2)]
        [DataRow(8, 2, 4)]
        [DataRow(12, 6, 2)]
        [DataRow(14, 7, 2)]
        [DataRow(16, 8, 2)]

        [TestCategory("Division")]

        public void TestMethodDivision(double a, double b, double x)
        {
            double actual = Class1.Division(a, b);
            Assert.AreEqual(x, actual);
        }
    }
}