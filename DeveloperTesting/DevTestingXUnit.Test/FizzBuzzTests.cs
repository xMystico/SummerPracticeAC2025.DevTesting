using FizzBuzz;

namespace DevTestingXUnit.Test
{
    public class FizzBuzzTests
    {
        private FizzBuzzCalculator _sut;

        public FizzBuzzTests()
        {
            _sut = new FizzBuzzCalculator();
        }

        [Fact]
        public void WhenEnteringANumberMultipleOfThree_Then_ItShouldReturnFizz()
        {
            //Arrange
            var number = 6;

            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void WhenEnteringANumberMultipleOfFive_Then_ItShouldReturnBuzz()
        {
            //Arrange
            var number = 10;
            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void WhenEnteringANumberMultipleOfThreeAndFive_Then_ItShouldReturnFizzBuzz()
        {
            //Arrange
            var number = 15;

            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void WhenEnteringAnInvalidNumber_Then_ItShouldReturnNothing()
        {
            //Arrange
            var number = 23;

            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.Equal(number.ToString(), result);
        }

        [Theory]
        [InlineData(6, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(23, "23")]
        public void GivenCalculate_When_IsCalledWithNumber_Then_ItShouldReturnExpectedResult(int number, string expectedResult)
        {
            //Arrange & Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }
    }
}