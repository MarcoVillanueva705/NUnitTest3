using NUnit.Framework;

namespace Tests
{
    public class StringCalculator_UnitTests
    {
        [Test]
        //method name, scenario under which testing, & expected outcome
        //public void UnitUnderTest_Scenario_ExpectedOutcome()
        public void Add_EmptyString_Returns_0()
        {
            StringCalculator calc = new StringCalculator();
            int expectedResult = 0;
            int result = calc.Add("");
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Add_SingleNumbers_ReturnsTheNumber()
        {
            StringCalculator calc = new StringCalculator();
            int expectedResult = 3;
            int result = calc.Add("3");
            Assert.AreEqual(expectedResult, result);
        }

    }
}