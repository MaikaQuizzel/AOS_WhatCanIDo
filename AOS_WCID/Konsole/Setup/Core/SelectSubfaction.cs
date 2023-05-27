using AOS_WCID.Data;
using AOS_WCID.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup.Core
{
    public class SelectSubfaction : InputValidator, ICoreSelection
    {
        private StringBuilder consoleText = new StringBuilder();
        private DataProvider? dataProvider;

        public void GenerateConsoleText()
        {
            consoleText.AppendLine("Which Subfaction do you want to play?");
        }

        public void ReadValidInput()
        {
            int subfactionCount = dataProvider.SubfactionList.Count();
            int subfactionID = -1;

            while (!IsValidSubfaction(subfactionID, subfactionCount))
            {
                Console.WriteLine(consoleText.ToString());
                int num = 0;
                for (int i = 0; i < subfactionCount; i++)
                {
                    Console.WriteLine($"{i} for {dataProvider.SubfactionList[i].Name}.");
                }

                int.TryParse(consolenReader.GetLine(), out subfactionID);

                if (!IsValidSubfaction(subfactionID, subfactionCount))
                    continue;

                PlayerPicks.Instance.Subfaction = dataProvider.SubfactionList[subfactionID];
                Console.WriteLine($"You picked {PlayerPicks.Instance.Subfaction.Name} as a Subfraction");
                ConsoleSpacer.PrintSpacer();

            }

            ConsoleSpacer.PrintSpacer();
        }


        public SelectSubfaction()
        {
            dataProvider = new DataProvider(new DataToWriteCollection());
        }

        public static bool IsValidSubfaction(int subfactionID, int subfactionCount)
        {
            return subfactionID >= 0 && subfactionID < subfactionCount;
        }
        public static bool NeedsCustomSubfaction()
        {
            return PlayerPicks.Instance.GameName.Equals(StringConstants.GAMEMODEPATH) && PlayerPicks.Instance.Subfaction.Name.Equals(StringConstants.NOSUBFACTION);
        }
    }
}
