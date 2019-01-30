using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Math();
            var result = math.Add(1, 2);
            Assert.AreEqual(result, 3);

        }

        [TestMethod]
        public void Max_WhenFirstArgumentIsGreaterThanTheSecond_ReturnTheFirstArgument()
        {
            var math = new Math();
            var result = math.Max(2, 1);
            Assert.AreEqual(result, 2);

        }
        [TestMethod]
        public void Max_WhenSecondArgumentIsGreaterThanTheFirst_ReturnTheSecondArgument()
        {
            var math = new Math();
            var result = math.Max(1, 2);
            Assert.AreEqual(result, 2);

        }
        [TestMethod]
        public void Max_WhenTheTwoArgumentsAreEqual_ReturnTheSameArgument()
        {
            var math = new Math();
            var result = math.Max(2, 2);
            Assert.AreEqual(result, 2);

        }
    }
}
