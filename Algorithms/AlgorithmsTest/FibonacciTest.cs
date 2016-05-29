using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmsTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Fibonacci_GetZeroElement()
        {
            //Arrange

            //Act
            var result = Fibonacci.Calculate(0);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Fibonacci_GetFirstElement()
        {
            //Arrange

            //Act
            var result = Fibonacci.Calculate(1);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Fibonacci_GetSecondElement()
        {
            //Arrange

            //Act
            var result = Fibonacci.Calculate(2);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Fibonacci_GetThirdElement()
        {
            //Arrange

            //Act
            var result = Fibonacci.Calculate(3);

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Fibonacci_GetFourthElement()
        {
            //Arrange

            //Act
            var result = Fibonacci.Calculate(4);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Fibonacci_GetFifthElement()
        {
            //Arrange

            //Act
            var result = Fibonacci.Calculate(5);

            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Fibonacci_GetSixthElement()
        {
            //Arrange

            //Act
            var result = Fibonacci.Calculate(6);

            //Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Fibonacci_GetCollectionOfFibonaccy()
        {
            //Arrange
            var criteria = new Dictionary<int, double>();

            for (var i = 0; i < 10; i++)
            {
                criteria[i] = Fibonacci.Calculate(i);
            }
            //Act
            var result = new Dictionary<int, double>().FibonacciSequence(9);

            //Assert
            CollectionAssert.AreEqual(criteria, result);
        }
    }
}