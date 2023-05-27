using AOS_WCID.Data;
using AOS_WCID.Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup.Core
{
    public class SelectFaction : InputValidator, ICoreSelection
    {
        private StringBuilder consoleText = new StringBuilder();
        private DataProvider? dataProvider;

        public void GenerateConsoleText()
        {
            consoleText.AppendLine("Which faction do you want to play?");
        }

        public void ReadValidInput()
        {
            int factionID = -1;
            int factionCount = dataProvider.FactionsList.Count();

            while (!IsValidFaction(factionID, factionCount))
            {
                Console.WriteLine(consoleText.ToString());
                for (int i = 0; i < factionCount; i++)
                {
                    Console.WriteLine($"{i} for {dataProvider.FactionsList[i].FactionName}");
                }

                int.TryParse(consolenReader.GetLine(), out factionID);
            }
            PlayerPicks.Instance.Faction = dataProvider.FactionsList[factionID];
            Console.WriteLine($"You picked {PlayerPicks.Instance.Faction.FactionName} as a faction");
            ConsoleSpacer.PrintSpacer();
        }

        private static bool IsValidFaction(int factionID, int listCount)
        {
            return factionID >= 0 && factionID < listCount;
        }

        public SelectFaction()
        {
            dataProvider = new DataProvider(new DataToWriteCollection());
        }
    }
}
