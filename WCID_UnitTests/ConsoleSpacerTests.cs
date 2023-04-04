using AOS_WCID.Konsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCID_UnitTests
{
    [TestClass]
    public class ConsoleSpacerTests
    {
        [TestMethod]
        public void PrintSpacer_Returns_Correct_String()
        {
            // Arrange
            string expected = "\n---------------\n";

            // Act
            ConsoleSpacer.PrintSpacer();
            string actual = Console.Out.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
