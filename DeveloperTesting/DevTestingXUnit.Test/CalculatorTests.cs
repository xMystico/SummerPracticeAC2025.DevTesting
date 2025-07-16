namespace DevTestingXUnit.Test
{
    public class CalculatorTests
    {
        private Calculator.Calculator _sut;
        public CalculatorTests()
        {
            _sut = new Calculator.Calculator();
        }

        [Fact]
        public void WhenAddingTwoNumbers_Then_ItShouldReturnTheSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _sut.Sum(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void WhenSubtractingTwoNumbers_Then_ItShouldReturnTheDifference()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _sut.Subtract(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void WhenMultiplyingTwoNumbers_Then_ItShouldReturnTheProduct()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _sut.Multiply(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void WhenDividingTwoNumbers_Then_ItShouldReturnTheQuotient()
        {
            // Arrange
            int a = 6;
            int b = 3;

            // Act
            var result = _sut.Divide(a, b);

            // Assert
            Assert.Equal(2, result);
        }
    }
}
