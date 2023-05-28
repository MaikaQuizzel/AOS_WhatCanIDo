using AOS_WCID.Data;
using AOS_WCID.Konsole.Setup.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCID_UnitTests.Mock;

namespace WCID_UnitTests.Test
{
    [TestClass]
    public class GrandAllianceSelectionTest
    {
        [TestMethod]
        public void TestValidSelection()
        {
            DataToWriteCollection coll = new DataToWriteCollection();
            coll.WriteStuffNow();

            SelectGrandAlliance selectGrandAlliance = new SelectGrandAlliance();

            TestConsoleReader reader = new TestConsoleReader();
            reader.ConsoleText = "0";
            selectGrandAlliance.consolenReader = reader;

            ((ICoreSelection)selectGrandAlliance).GenerateConsoleText();
            ((ICoreSelection)selectGrandAlliance).ReadValidInput();
        }


        [TestMethod]
        [Timeout(500)]
        [ExpectedException(typeof(TimeoutException),
            "Wrong Input. Loop is not escaped.")]
        public void TestInvalidSelection()
        {
            DataToWriteCollection coll = new DataToWriteCollection();
            coll.WriteStuffNow();

            SelectGrandAlliance selectGrandAlliance = new SelectGrandAlliance();

            TestConsoleReader reader = new TestConsoleReader();
            reader.ConsoleText = "5";
            selectGrandAlliance.consolenReader = reader;

            ((ICoreSelection)selectGrandAlliance).GenerateConsoleText();
            ((ICoreSelection)selectGrandAlliance).ReadValidInput();
        }
    }
}