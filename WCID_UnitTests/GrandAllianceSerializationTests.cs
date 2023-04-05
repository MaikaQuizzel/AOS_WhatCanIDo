using AOS_WCID.Entities;
using Hangfire.Common;
using AOS_WCID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOS_WCID.Data;

namespace WCID_UnitTests
{
    [TestClass]
    public class GrandAllianceSerializationTests
    {

        [TestMethod]
        public void TestReadGrandAllianceJsonToPath()
        {
            // Arrange
            List<GrandAlliance> expected = new List<GrandAlliance>()
            {
                new GrandAlliance("Order"),
                new GrandAlliance("Chaos"),
                new GrandAlliance("Death"),
                new GrandAlliance("Destruction")
            };
            DataManager.WriteGrandAllianceJsonToPath(expected);

            // Act
            List<GrandAlliance> actual = DataManager.ReadGrandAllianceJsonToPath();

            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
            }
        }
    }

}
