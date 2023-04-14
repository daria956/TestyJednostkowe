using AutoFixture.NUnit3;

namespace TestyJednostkowe.Tests
{
    public class Tests
    {
        //{
        //    [SetUp]
        //    public void Setup()
        //    {
        //    }

        [Test]
        [TestCase(4, 5, 20)]
        public void Multiplication_TwoVariables_Result(int a, int b, int c)
        {
            //Arrange
            var calculator = new Calculator();


            //Act
            var result = calculator.Multiplication(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(c));
            Assert.That(result, Is.GreaterThan(0));
            Assert.IsNotNull(result);

        }
        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(21,3, 7)]
        public void Division_TwoVariables_GivesResult(int a, int b, int c)
        {
            //Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Division(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(c));
            Assert.That(result, Is.GreaterThan(0));
            Assert.IsNotNull(result);

        }
        [Test, AutoData]
        public void MultiplicationAndDivion(int a, int b, int c)
        {
            //Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.MultiplicationAndDivion(a, b, c);

            //Assert
            Assert.That(result, Is.EqualTo(result));
            Assert.That(result, Is.GreaterThan(0));
            Assert.IsNotNull(result);

        }
    }
}