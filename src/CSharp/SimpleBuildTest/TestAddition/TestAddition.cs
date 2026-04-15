using SimpleBuildTest;

namespace TestAddition
{
    public class TestAddition
    {
        [Fact]
        public void AddTwoIntegers_validNumbers_correctResult()
        {
            // Arrange
            int number1 = 2;
            int number2 = 3;
            int expectedResult = 5;

            // Act
            int actualResult = Addition.AddTwoIntegers(number1, number2);
            
            // Assert
            Assert.Equal(expectedResult, actualResult);

        }

         
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        [InlineData(12, 2, 14)]
        [InlineData(14, 54, 68)]
        [InlineData(12, 55, 67)]
        public void AddTwoIntegers_validDataSet_correctResult(int value1, int value2, int expected)
        {
            // Act
            int actualResult = Addition.AddTwoIntegers(value1, value2);

            // Assert
            Assert.Equal(expected, actualResult);

        }
    }
}
