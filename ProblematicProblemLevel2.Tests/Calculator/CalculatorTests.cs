using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ProblematicLibrary.Calculator;

namespace ProblematicProblemLevel2.Tests
{
    public class CalculatorTests
    {
        private static Calculator sut = new Calculator(); // sut = System Under Test - The object that has the methods we are testing

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(0,1,1)]
        [InlineData(-100,1,-99)]
        [InlineData(50,-50,0)]
        [InlineData(10000,-5000,5000)]
        public void Should_AddTwoNumbers(double x, double y, int expected)
        {
            double actual = sut.Add(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(0, 1, -1)]
        [InlineData(-100, 1, -101)]
        [InlineData(50, -50, 100)]
        [InlineData(10000, -5000, 15000)]
        [InlineData(10000, 5000, 5000)]
        [InlineData(0, 0, 0)]
        public void Should_SubtractTwoNumbers(double x, double y, int expected)
        {
            double actual = sut.Subtract(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-100, 1, -100)]
        [InlineData(50, -50, -2500)]
        [InlineData(10, -5, -50)]
        [InlineData(10, 5, 50)]
        [InlineData(5, 3, 15)]
        [InlineData(1.1, 3.5, 3.85)]
        [InlineData(5.5, 2, 11)]
        public void Should_MultiplyTwoNumbers(double x, double y, int expected)
        {
            double actual = sut.Multiply(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(0, 1, 0)]
        [InlineData(-100, 1, -100)]
        [InlineData(-100, 2, -50)]
        [InlineData(-100, -2, 50)]
        [InlineData(10000, -5000, -2)]
        [InlineData(10000, 5000, 2)]
        public void Should_DivideTwoNumbers(double x, double y, int expected)
        {
            double actual = sut.Divide(x, y);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldNot_DivideByZero()
        {
            double expected = -1;

            double actual = sut.Divide(10, 0);

            Assert.Equal(expected, actual);
        }
    }
}
