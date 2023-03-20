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
    public class CoreSetup:InputValidator
    {
        private PlayerPicks playerPick;
        private InitialStuff initialStuff;
        

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
                
                IsValidInput(new List<int> { 1, 2 }, out gameMode);

                IsValidInput(new List<string> { "Maike" });

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
                if (NeedsCustomSubfaction(playerPick))
                {
                    CustomSubfaction();
                }
            }
        }
        public static bool IsValidSubfaction(int subfactionID, int subfactionCount)
        {
            return subfactionID >= 0 && subfactionID < subfactionCount;
        }
        public static bool NeedsCustomSubfaction(PlayerPicks playerPick)
        {
            return playerPick.GameName.Equals(StringConstants.GAMEMODEPATH) && playerPick.Subfaction.Name.Equals(StringConstants.NOSUBFACTION);
        }
       
        public void CustomSubfaction()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.AppendLine("Was ist deine erste Liste?");
            int tenetID = -1;
            int tenetCount = initialStuff.TenetList.Count();

            while (!IsValidPickTenet()) {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < tenetCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.TenetList[i].Name}");
                }
                int.TryParse(consolenReader.GetLine(), out tenetID);
                if (IsValidPickTenet())
                {
                    int tenetAbilityID = -1;
                    Tenets currentTenet = initialStuff.TenetList[tenetID];
                    chooseText.Clear();
                    chooseText.AppendLine("Wähle deine erste Fähigkeit");

                    while (IsValidPickTenetAbility())
                    {
                        for (int i = 0; i < currentTenet.Abilities.Count(); i++)
                        {
                            Console.WriteLine($"{i} für {currentTenet.Abilities[i].Name}");
                        }
                        int.TryParse(consolenReader.GetLine(), out tenetAbilityID);
                        if (IsValidPickTenetAbility())
                        {
                            playerPick.TenetAbilities.Add(currentTenet.Abilities[tenetAbilityID]);
                        }
                    }
                }
            }
            chooseText.Clear();
            chooseText.AppendLine("Wähle deine zweite Liste");
            int secondTenetID = -1;
            while (IsValidPickTenet())
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < tenetCount; i++)
                {
                    if(i != tenetID)
                    Console.WriteLine($"{i} für {initialStuff.TenetList[i].Name}");
                }
                int.TryParse(consolenReader.GetLine(), out secondTenetID);
                if (IsValidPickTenet())
                {
                    int tenetAbilityID = -1;
                    Tenets currentTenet = initialStuff.TenetList[secondTenetID];
                    chooseText.Clear();
                    chooseText.AppendLine("Wähle deine zweite Fähigkeit");

                    while (IsValidPickTenetAbility())
                    {
                        for (int i = 0; i < currentTenet.Abilities.Count(); i++)
                        {
                            Console.WriteLine($"{i} für {currentTenet.Abilities[i].Name}");
                        }
                        int.TryParse(consolenReader.GetLine(), out tenetAbilityID);
                        if (IsValidPickTenetAbility())
                        {
                            playerPick.TenetAbilities.Add(currentTenet.Abilities[tenetAbilityID]);
                        }
                    }
                }
            }


        }
        public static bool IsValidPickTenet() 
        { 
            return false; 
        }
        public static bool IsValidPickTenetAbility() 
        { 
            return false; 
        }

    }
}
