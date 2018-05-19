using fizzbuzz.library;
using NUnit.Framework;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void DivisableByFive_HappyPath()
        {
            //Arrange
            var input = 5;

            //Act
            var _testObject = new FizzBuzzer().DetermineIsDivisable(input);

            //Assert
            Assert.AreEqual("buzz", _testObject);
        }

        [Test]
        public void DivisableByFive_NotDivisableNumberPassedIn()
        {
            //Arrange
            var input = 4;

            //Act
            var _testObject = new FizzBuzzer().DetermineIsDivisable(input);

            //Assert
            Assert.AreEqual(input.ToString(), _testObject);
        }

        [Test]
        public void DivisableByThree_HappyPath()
        {
            //Arrange
            var input = 3;

            //Act
            var _testObject = new FizzBuzzer().DetermineIsDivisable(input);

            //Assert
            Assert.AreEqual("fizz", _testObject);
        }

        [Test]
        public void DivisableByThree_NotDivisableNumberPassedIn()
        {
            //Arrange
            var input = 2;

            //Act
            var _testObject = new FizzBuzzer().DetermineIsDivisable(input);

            //Assert
            Assert.AreEqual(input.ToString(), _testObject);
        }

        [Test]
        public void DivisableByThreeAndFive_HappyPath()
        {
            //Arrange
            var input = 15;

            //Act
            var _testObject = new FizzBuzzer().DetermineIsDivisable(input);

            //Assert
            Assert.AreEqual("fizzbuzz", _testObject);
        }

        [Test]
        public void DivisableByThreeAndFive_NotDivisableNumberPassedIn()
        {
            //Arrange
            var input = 1;

            //Act
            var _testObject = new FizzBuzzer().DetermineIsDivisable(input);

            //Assert
            Assert.AreEqual(input.ToString(), _testObject);
        }
    }
}