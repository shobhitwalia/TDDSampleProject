using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopementExample;

namespace TestDrivenDevelopementExample.Test
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void GetFibonacciNumber_Given0_Return0()
        {
            //arrange
            int number = 0;
            
            //act
            int result = Fibonacci.GetFibonacciNumber(number);

            //assert
            Assert.AreEqual(0, result); 
        }

        [TestMethod]
        public void GetFibonacciNumber_Given1_Return1()
        {
            //arrange
            int number = 1;

            //act
            int result = Fibonacci.GetFibonacciNumber(number);

            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetFibonacciNumber_Given2_Return1()
        {
            //arrange
            int number = 2;

            //act
            int result = Fibonacci.GetFibonacciNumber(number);

            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetFibonacciNumber_Given3_Return2()
        {
            //arrange
            int number = 3;

            //act
            int result = Fibonacci.GetFibonacciNumber(number);

            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetFibonacciNumber_Given4_Return3()
        {
            //arrange
            int number = 4;

            //act
            int result = Fibonacci.GetFibonacciNumber(number);

            //assert
            Assert.AreEqual(3, result);
        }

    }
}
