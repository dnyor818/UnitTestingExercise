using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(4, 4, 4, 12)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9, 9, 0)]
        [InlineData (5, 4, 1)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(4, 5, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(15, 5, 3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addy()
        {
            //Arrange9
            var test = new UnitTestMethods();
            var y = 6;
            var x = 5;
            var expected = 11;
            //Act
            var actual = test.Addy(y, x);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyMethod()
        {
            //Arrange
            var test = new UnitTestMethods();
            var d = "Derek";
            var expected = "Derek";
            //Act
            var actual = test.MyMethod(d);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
