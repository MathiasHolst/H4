using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lommeregner_backend;

namespace Lommeregner_Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CalculatorDisplayValue_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = 44;
            
            //Act
            cal.CalculatorDisplayValue = exp;

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp);
        }

        [TestMethod]
        public void Add_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = 50;

            //Act
            cal.CalculatorDisplayValue = 25;
            cal.Add(25);

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp);
        }

        [TestMethod]
        public void AddWithNegativeNumbers_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = -50;

            //Act
            cal.CalculatorDisplayValue = -25;
            cal.Add(-25);
            
            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp);
        }
        
        [TestMethod]
        public void AddWithDoubles_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = 2.2f;

            //Act
            cal.CalculatorDisplayValue = 1.1f;
            cal.Add(1.1f);

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp, 0.2);
        }

        [TestMethod]
        public void Sub_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = 25;

            //Act
            cal.CalculatorDisplayValue = 50;
            cal.Subtract(25);

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp);
        }

        [TestMethod]
        public void SubInMinus_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = -1;

            //Act
            cal.CalculatorDisplayValue = 4;
            cal.Subtract(5);

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp);
        }

        [TestMethod]
        public void SubInDoubles_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = 0.9f;

            //Act
            cal.CalculatorDisplayValue = 2.0f;
            cal.Subtract(1.1f);

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp, 0.2);
        }

        [TestMethod]
        public void Multiplication_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = 25;

            //Act
            cal.CalculatorDisplayValue = 5;
            cal.Multiply(5);

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp);
        }

        [TestMethod]
        public void MultiWithZero_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = 0;

            //Act
            cal.CalculatorDisplayValue = 5;
            cal.Multiply(0);

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp);
        }

        [TestMethod]
        public void Division_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = 5;

            //Act
            cal.CalculatorDisplayValue = 25;
            cal.Divide(5);

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp);
        }

        [TestMethod]
        public void DivisionWithNegativeNumber_Test()
        {
            //Arrange
            var cal = new Calculator();
            float exp = -4;

            //Act
            cal.CalculatorDisplayValue = -12;
            cal.Divide(3);

            //Assert
            Assert.AreEqual(cal.CalculatorDisplayValue, exp);
        }

    }
}

