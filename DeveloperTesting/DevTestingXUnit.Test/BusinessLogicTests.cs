using NSubstitute;
using Repository;

namespace DevTestingXUnit.Test
{
    public class BusinessLogicTests
    {
        private readonly BusinessLogic.BusinessLogic _sut;
        private readonly IRepository _repositoryMock;

        public BusinessLogicTests()
        {
            _repositoryMock = Substitute.For<IRepository>();
            _sut = new BusinessLogic.BusinessLogic(_repositoryMock);
        }

        [Fact]
        public void Should_ReturnRateOfGraduatedStudents_When_GetGraduationRateIsCalled()
        {
            //Arrange
            var studentList = new List<Student>()
            {
                new () { Name = "Denis", Grade = 2 },
                new () { Name = "Alex", Grade = 10 }
            };

            _repositoryMock.GetStudents().Returns(studentList);
            var expected = 50;

            //Act
            var result = _sut.GetGraduationRate();

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
