using AOS_WCID.Konsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCID_UnitTests
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
            Console.SetIn(new System.IO.StringReader(expected));
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
            Console.SetIn(new System.IO.StringReader(""));
            string actual = reader.GetLine();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
