using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCID_UnitTests.Mock;

namespace WCID_UnitTests
{
    [TestClass]
    public class InputValidatorTest
    {
        [TestMethod]
        public void TestValidInput()
        {
            int testInput = 1;
            int testOutput = -1;

            TestInputValidator validator = new TestInputValidator();
            TestConsoleReader testReader = new TestConsoleReader();

            validator.consolenReader = testReader;
            testReader.ConsoleText = testInput.ToString();

            validator.IsValidInput(new List<int>() { 0, 1, 2 }, out testOutput);

            Assert.AreEqual(testInput, testOutput);
        }

        [TestMethod]
        public void TestInvalidInput()
        {
            int testInput = 5;
            int testOutput = -1;

            TestInputValidator validator = new TestInputValidator();
            TestConsoleReader testReader = new TestConsoleReader();

            validator.consolenReader = testReader;
            testReader.ConsoleText = testInput.ToString();

            validator.IsValidInput(new List<int>() { 0, 1, 2 }, out testOutput);

            Assert.AreEqual(-1, testOutput);
        }
    }
}
