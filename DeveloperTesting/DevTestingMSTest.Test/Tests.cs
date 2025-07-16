using FizzBuzz;

namespace DevTestingMSTest.Test
{
    [TestClass]
    public class Tests
    {
        private readonly FizzBuzzCalculator _sut;

        public Tests()
        {
            _sut = new FizzBuzzCalculator();
        }

        [TestMethod]
        public void WhenEnteringANumberMultipleOfThree_Then_ItShouldReturnFizz()
        {
            //Arrange
            var number = 6;

            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void WhenEnteringANumberMultipleOfFive_Then_ItShouldReturnBuzz()
        {
            //Arrange
            var number = 10;
            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void WhenEnteringANumberMultipleOfThreeAndFive_Then_ItShouldReturnFizzBuzz()
        {
            //Arrange
            var number = 15;

            //Act
            var result = _sut.Calculate(number);

            //Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
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
