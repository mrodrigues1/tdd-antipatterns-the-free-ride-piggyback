using Xunit;

namespace TddAntipatterns.TheFreeRidePiggyBack
{
    public class DiscountCalculatorTests
    {
[Fact]
public void CalculateDiscount_ExpectedDiscountForFirstTimePurchase()
{
    //Arrange            
    decimal expected = 0.1M;
    decimal expectedResultAge = 0.2M;

    var sut = new DiscountCalculator();

    //Act
    var result = sut.CalculateDiscount(true, 30);
    var resultAge = sut.CalculateDiscount(false, 65);

    //Assert            
    Assert.Equal(expected, result);
    Assert.Equal(expectedResultAge, resultAge);
}

[Fact]
public void CalculateDiscount_FirstPurchaseTrueAsParameter_Expected10PercentDiscount()
{
    //Arrange
    int age = 30;
    bool firstPurchase = true;
    decimal expectedResult = 0.1M;

    var sut = new DiscountCalculator();

    //Act
    var result = sut.CalculateDiscount(firstPurchase, age);

    //Assert
    Assert.Equal(expectedResult, result);
}

[Fact]
public void CalculateDiscount_Age65AsParameter_Expected20PercentDiscount()
{
    //Arrange
    int age = 64;
    bool firstPurchase = false;
    decimal expectedResult = 0.2M;

    var sut = new DiscountCalculator();

    //Act
    var result = sut.CalculateDiscount(firstPurchase, age);

    //Assert
    Assert.Equal(expectedResult, result);
}
    }
}
