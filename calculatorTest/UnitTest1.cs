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


    }
}