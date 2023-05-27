using AOS_WCID.Data;
using AOS_WCID.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup.Core
{
    public class SelectGrandAlliance : InputValidator, ICoreSelection
    {
        private StringBuilder consoleText = new StringBuilder();
        private DataProvider? dataProvider; 

        public void ReadValidInput()
        {
            int listCount = dataProvider.AlliancesList.Count();
            int allianceID = -1;

            while (!IsValidGrandAlliance(allianceID, listCount))
            {
                Console.WriteLine(consoleText.ToString());

                for (int i = 0; i < listCount; i++)
                {
                    Console.WriteLine($"{i} for {dataProvider.AlliancesList[i].Name}");
                }

                int.TryParse(consolenReader.GetLine(), out allianceID);

                if (IsValidGrandAlliance(allianceID, listCount))
                {
                    PlayerPicks.Instance.GrandAlliance = dataProvider.AlliancesList[allianceID];
                    Console.WriteLine($"You picked {PlayerPicks.Instance.GrandAlliance.Name}.");
                }
            }
            ConsoleSpacer.PrintSpacer();
        }

        public void GenerateConsoleText()
        {
            consoleText.AppendLine("Which Alliance do you want to play?"); 
        }

        private static bool IsValidGrandAlliance(int allianceID, int listCount)
        {
            return allianceID >= 0 && allianceID < listCount;
        }


        public SelectGrandAlliance()
        {
            dataProvider = new DataProvider(new DataToWriteCollection());
        }
    }
}
