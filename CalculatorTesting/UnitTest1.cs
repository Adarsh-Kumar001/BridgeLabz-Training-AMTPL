using NUnit.Framework;
using BridgeLabz_Training.nunittesting;  //right click dependencies and refernce the BridgeLabz-Training project then import the namespace of file we need to test

namespace CalculatorTesting
{
    public class Tests
    {

        private calculator calc;


        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            // Runs once before all tests 
        }

        [SetUp]
        public void Setup()
        {
            // Runs before each test
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
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.That(calc.Add(2,3), Is.EqualTo(5));

        }

        [Test]
        public void Divide_ByZero_Throws()
        {
            Assert.Throws<System.DivideByZeroException>(() => calc.Div(1, 0));
        }

    }
}