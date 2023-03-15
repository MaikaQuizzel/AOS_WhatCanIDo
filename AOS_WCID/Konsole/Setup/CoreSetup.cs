using AOS_WCID.Data;
using AOS_WCID.Entities;
using AOS_WCID.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup
{
    public class CoreSetup
    {
        private PlayerPicks playerPick;
        private InitialStuff initialStuff;
        private ConsolenReader consolenReader;

        public CoreSetup(PlayerPicks picks, InitialStuff initStuff)
        {
            playerPick = picks;
            initialStuff = initStuff;
            consolenReader = new ConsolenReader();
        }

        public void EingabeGameMode()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.Append("Für welchen Spielmodus möchtest du erstellen");
            chooseText.AppendLine("\n 1 für Path to Glory \n 2 für normal");

            int gameMode = -1;

            while (gameMode != 1 && gameMode != 2)
            {
                Console.WriteLine(chooseText.ToString());
                int.TryParse(consolenReader.GetLine(), out gameMode);
                
                if (gameMode == 1 || gameMode == 2)
                {
                    playerPick.GameName = gameMode == 1 ? StringConstants.GAMEMODEPATH : "Normal";
                    Console.WriteLine($"Du hast {playerPick.GameName} gewählt.");
                    continue;
                }

                Console.WriteLine("\" 1\" oder \" 2\" eingeben");
            }

        }

        public void EingabeGrandAlliance()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.AppendLine("Welche Alliance willst du spielen");
            int listCount = initialStuff.AlliancesList.Count();
            int allianceID=-1;

            while (!IsValidGrandAlliance(allianceID, listCount))
            {
                Console.WriteLine(chooseText.ToString());

                for (int i = 0; i < listCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.AlliancesList[i].Name}");
                }

                int.TryParse(consolenReader.GetLine(), out allianceID);
                
                if (IsValidGrandAlliance(allianceID, listCount))
                {
                    playerPick.GrandAlliance = initialStuff.AlliancesList[allianceID];
                    Console.WriteLine($"Du hast {playerPick.GrandAlliance.Name} gewählt");
                }
            }
        }
        private static bool IsValidGrandAlliance(int allianceID, int listCount) 
        {
            return allianceID >= 0 && allianceID < listCount;
        }

        public void EingabeFaction()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.AppendLine("Welche Fraktion möchtest du spielen?");

            int factionID= -1;
            int factionCount = initialStuff.FactionsList.Count();

            while (!IsValidFaction(factionID, factionCount))
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < factionCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.FactionsList[i].FactionName}");
                }

                int.TryParse(consolenReader.GetLine(), out factionID);

                if (IsValidFaction(factionID, factionCount))
                {
                    playerPick.Faction = initialStuff.FactionsList[factionID];
                    Console.WriteLine($"Du hast {playerPick.Faction.FactionName} als Fraktion gewählt");
                }
            }
        }
        private static bool IsValidFaction(int factionID, int listCount) 
        {
            return factionID >= 0 && factionID < listCount;
        }
        public void EingabeSubfaction()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.AppendLine("Welche Subfrakion möchtest du spielen?");

            int subfactionCount = initialStuff.SubfactionList.Count();
            int subfactionID = -1;
            while (!IsValidSubfaction(subfactionID,subfactionCount))
            {
                Console.WriteLine(chooseText.ToString());
                int num = 0;
                foreach (Subfaction i in initialStuff.SubfactionList)
                {
                    Console.WriteLine($"{num} für {i.Name}.");
                }

                int.TryParse(consolenReader.GetLine(), out subfactionID);

                if (!IsValidSubfaction(subfactionID, subfactionCount))
                    continue;

                playerPick.Subfaction = initialStuff.SubfactionList[subfactionID];
                Console.WriteLine($"Du hast {playerPick.Subfaction.Name} als Subraktion gewählt");
                if (playerPick.GameName.Equals(StringConstants.GAMEMODEPATH) && playerPick.Subfaction.Name.Equals(StringConstants.NOSUBFACTION))
                {
                    CustomSubfaction();
                    
                }
            }
        }
        public static bool IsValidSubfaction(int subfactionID, int subfactionCount)
        {
            return subfactionID >= 0 && subfactionID < subfactionCount;
        }
        publich
        public void CustomSubfaction()
        {
            Console.WriteLine("Eye of the Storm und Celestial Radiance");
            //2 listen auswählen

            // 2 fähigkeiten auswählen
        }

    }
}
