using NUnit.Framework;
using BridgeLabz_Training.nunittesting;  //right click dependencies and refernce the BridgeLabz-Training project then import the namespace of file we need to test

namespace CalculatorTesting
{
    public class Tests    //follow AAA for a good test case - arrange (sets up variables), act(calls method under tests) , assert(check)
    {

        private calculator calc;


        [OneTimeSetUp]         //these are lifecycle methods and lets us setup code before each test case - setup, onetimesetup, teardown etc..
        public void OneTimeSetup()
        {
            // Runs once before all tests 
        }

        [SetUp]
        public void Setup()
        {
            // Runs before each test, hence fresh instance before each test
            calc = new calculator();
        }

        [TearDown]
        public void TearDown()
        {
            // Runs after each test
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Runs once after all tests in this fixture
        }


        //tests

        [Test]
        public void Multiply_PositiveNumbers_ReturnsPositiveProduct()  //a good test case
        {
            // Arrange
            var calc = new calculator();

            // Act
            int result = calc.Mul(5, 3);

            // Assert
            Assert.That(result, Is.EqualTo(15));
        }


        [Test]
        public void Add_TwoNumbers_ReturnsSum()        //without repetitve code
        {
            Assert.That(calc.Add(2,3), Is.EqualTo(5));  

        }

        [Test]
        public void Divide_ByZero_Throws()
        {
            Assert.Throws<System.DivideByZeroException>(() => calc.Div(1, 0));
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsCorrectValue()
        {
            Assert.That(calc.Add(-2, -3), Is.EqualTo(-5));
        }

        //press test then run all test cases to test

    }
}