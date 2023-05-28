using AOS_WCID.Data;
using AOS_WCID.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCID_UnitTests.Logic
{
    [TestClass]
    public class CompareAbilitysTest
    {
        [TestMethod]
        public void TestValidAbilityFromPhase()
        {
            string ability = "A random Attack: ward";
            string phase = StringConstants.COMBATPHASE;
            bool awaitedoutcome = true;

            bool outcome = SpecialWordsComparator.CompareAbilitiyToList(ability, phase);

            Assert.IsTrue(outcome);
        }

        [TestMethod]
        public void TestValidAbilityFromUnvalidPhase()
        {
            string ability = "A random Attack: ward";
            string phase = "Bullseye";
            bool awaitedoutcome = true;

            bool outcome = SpecialWordsComparator.CompareAbilitiyToList(ability, phase);

            Assert.IsFalse(outcome);
        }
        [TestMethod]
        public void TestUnvalidAbilityFromValidPhase()
        {
            string ability = "gvbrshjbfgklweuFHOÖEUIfhuoÖWEFHWEUOÖH";
            string phase = StringConstants.COMBATPHASE;
            bool awaitedoutcome = true;

            bool outcome = SpecialWordsComparator.CompareAbilitiyToList(ability, phase);

            Assert.IsFalse(outcome);
        }
    }
}
