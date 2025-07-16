using FizzBuzz;

namespace DevTestingNUnit.Test
{
    public class Tests
    {
        private FizzBuzzCalculator _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new FizzBuzzCalculator();
        }

        [Test]
        public void WhenEnteringANumberMultipleOfThree_Then_ItShouldReturnFizz()
        {
            //Arrange
            var number = 6;

            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void WhenEnteringANumberMultipleOfFive_Then_ItShouldReturnBuzz()
        {
            //Arrange
            var number = 10;
            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void WhenEnteringANumberMultipleOfThreeAndFive_Then_ItShouldReturnFizzBuzz()
        {
            //Arrange
            var number = 15;

            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void WhenEnteringAnInvalidNumber_Then_ItShouldReturnNothing()
        {
            //Arrange
            var number = 23;

            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.AreEqual(number.ToString(), result);
        }
    }
}