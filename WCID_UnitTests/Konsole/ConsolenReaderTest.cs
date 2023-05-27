using AOS_WCID.Konsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCID_UnitTests.Konsole
{
    [TestClass]
    public class ConsolenReaderTest
    {
        [TestMethod]
        public void TestGetLine()
        {
            // Arrange
            string expected = "Hello World!";
            ConsolenReader reader = new ConsolenReader();

            // Act
            Console.SetIn(new StringReader(expected));
            string actual = reader.GetLine();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetLineEmpty()
        {
            // Arrange
            string expected = "";
            ConsolenReader reader = new ConsolenReader();

            // Act
            Console.SetIn(new StringReader(""));
            string actual = reader.GetLine();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
