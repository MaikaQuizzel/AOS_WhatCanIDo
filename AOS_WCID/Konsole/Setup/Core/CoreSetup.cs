using AOS_WCID.Data;
using AOS_WCID.Entities;
using AOS_WCID.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup.Core
{
    public class CoreSetup : InputValidator
    {
        private DataProvider dataProvider;

        public DataProvider DataProvider { get => dataProvider; set => dataProvider = value; }

        public CoreSetup(DataProvider dataProviders)
        {
            dataProvider = dataProviders;
            consolenReader = new ConsolenReader();
        }

        public void RunSetup()
        {
            List<ICoreSelection> selectors = new List<ICoreSelection>()
            {
                new SelectGameMode(),
                new SelectGrandAlliance(),
                new SelectFaction(),
                new SelectSubfaction()
            };

            foreach (ICoreSelection iCoreSelection in selectors)
            {
                iCoreSelection.GenerateConsoleText();
                iCoreSelection.ReadValidInput();
            }

            if (!NeedsCustomSubfaction()) return;

            selectors = new List<ICoreSelection>()
            {
                new SelectTenet(),
                new SelectTenetAbility()
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    selectors[j].GenerateConsoleText();
                    selectors[j].ReadValidInput();
                }
            }
        }

        public static bool NeedsCustomSubfaction()
        {
            return PlayerPicks.Instance.GameName.Equals(StringConstants.GAMEMODEPATH) && PlayerPicks.Instance.Subfaction.Name.Equals(StringConstants.NOSUBFACTION);
        }

    }
}
