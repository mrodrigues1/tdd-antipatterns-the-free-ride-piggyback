using System;
using Xunit;

namespace TddAntipatterns.TheFreeRidePiggyBack
{
    public class DiscountCalculatorTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int age = 65;
            decimal expectedResult = 0.2M;

            var sut = new DiscountCalculator();

            //Act
            var result = sut.CalculateDiscount1(age);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            int age = 65;
            bool firstPurchase = true;
            decimal expected = 0.2M;
            decimal expectedResultFirstPurchase = 0.1M;

            var sut = new DiscountCalculator();

            //Act
            var result = sut.CalculateDiscount(age, false);
            var resultFirstPurchase = sut.CalculateDiscount(30, firstPurchase);

            //Assert
            Assert.Equal(expected, result);
            Assert.Equal(expectedResultFirstPurchase, resultFirstPurchase);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            int age = 30;
            bool firstPurchase = true;
            decimal expectedResult = 0.1M;

            var sut = new DiscountCalculator();

            //Act
            var result = sut.CalculateDiscount(age, firstPurchase);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
