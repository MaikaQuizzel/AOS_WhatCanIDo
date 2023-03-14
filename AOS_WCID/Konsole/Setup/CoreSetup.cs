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
                    playerPick.GameName = gameMode == 1 ? "Path to Glory" : "Normal";
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
            bool validEntry = false;
            int factionID;
            while (!validEntry)
            {
                Console.WriteLine("Welche Fraktion möchtest du spielen?");
                int num = 0;
                foreach (Faction i in initialStuff.FactionsList)
                {
                    Console.WriteLine($"{num} für {i.FactionName}.");
                }
                ConsolenReader reader = new ConsolenReader();
                string eingabe = reader.GetLine();
                int.TryParse(eingabe, out factionID);
                validEntry = factionID >= 0 && factionID <= num;
                if (!validEntry) { Console.WriteLine($"Wähle zwischen 0 und {num}."); }
                if (validEntry)
                {
                    playerPick.Faction = initialStuff.FactionsList[factionID];
                    Console.WriteLine($"Du hast {playerPick.Faction.FactionName} als Fraktion gewählt");
                }
            }
        }
        private static bool IsValidFaction() { }
        public void EingabeSubfaction()
        {
            bool validEntry = false;
            int subfactionID;
            while (!validEntry)
            {
                Console.WriteLine("Welche Subfrakion möchtest du spielen?");
                int num = 0;
                foreach (Subfaction i in initialStuff.SubfactionList)
                {
                    Console.WriteLine($"{num} für {i.Name}.");
                }
                ConsolenReader reader = new ConsolenReader();
                string eingabe = reader.GetLine();
                int.TryParse(eingabe, out subfactionID);
                validEntry = subfactionID >= 0 && subfactionID <= num;
                if (!validEntry) { Console.WriteLine($"Wähle zwischen 0 und {num}."); }
                if (validEntry)
                {
                    playerPick.Subfaction = initialStuff.SubfactionList[subfactionID];
                    Console.WriteLine($"Du hast {playerPick.Subfaction.Name} als Subraktion gewählt");
                    if (playerPick.GameName == "Path to Glory" && playerPick.Subfaction.Name == "No Subfaction")
                    {
                        CustomSubfaction();
                    }
                }
            }
        }
        public void CustomSubfaction()
        {
            Console.WriteLine("Eye of the Storm und Celestial Radiance");
            //2 listen auswählen

            // 2 fähigkeiten auswählen
        }

    }
}
