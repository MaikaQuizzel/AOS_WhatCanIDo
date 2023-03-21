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
        private DataProvider initialStuff;

        public PlayerPicks PlayerPick { get => playerPick; set => playerPick = value; }
        public DataProvider InitialStuff { get => initialStuff; set => initialStuff = value; }

        public CoreSetup(PlayerPicks picks, DataProvider initStuff)
        {
            playerPick = picks;
            initialStuff = initStuff;
            consolenReader = new ConsolenReader();
        }

        

        public void EingabeGameMode()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.Append("Für welchen Spielmodus möchtest du erstellen");
            chooseText.AppendLine("\n 0 für Path to Glory \n 1 für normal");

            int gameMode = -1;

            while (gameMode != 0 && gameMode != 1)
            {
                Console.WriteLine(chooseText.ToString());
                
                IsValidInput(new List<int> { 0, 1 }, out gameMode);

                if (gameMode == 0 || gameMode == 1)
                {
                    playerPick.GameName = gameMode == 0 ? StringConstants.GAMEMODEPATH : "Normal";
                    Console.WriteLine($"Du hast {playerPick.GameName} gewählt.");
                    continue;
                }
                Console.WriteLine("\" 0\" oder \" 1\" eingeben");
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
                for (int i = 0; i < subfactionCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.SubfactionList[i].Name}.");
                }

                int.TryParse(consolenReader.GetLine(), out subfactionID);

                if (!IsValidSubfaction(subfactionID, subfactionCount))
                    continue;

                playerPick.Subfaction = initialStuff.SubfactionList[subfactionID];
                Console.WriteLine($"Du hast {playerPick.Subfaction.Name} als Subraktion gewählt");
                
                if (NeedsCustomSubfaction(playerPick))
                {
                    PickTenet();
                    initialStuff.TenetList.Remove(playerPick.Tenets[0]);
                    PickTenetAbillity();
                    PickTenet();
                    PickTenetAbillity();
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
       

        public void PickTenet() 
        {
            StringBuilder chooseText = new StringBuilder();
            
            chooseText.AppendLine(playerPick.Tenets.Count()==0 ? "Was ist deine erste Liste?" : "Was ist deine zweite Liste?") ;

            int tenetID = -1;
            
            int tenetCount = initialStuff.TenetList.Count();
            bool isValidTenet = false;

            while (!isValidTenet)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < tenetCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.TenetList[i].Name}");
                }
                isValidTenet = IsValidInput(tenetCount, out tenetID);
            }
            playerPick.Tenets.Add( initialStuff.TenetList[tenetID]);
        }

        public void PickTenetAbillity()
        {
            Tenets currentTenet = playerPick.Tenets.Last();
            int tenetAbilityID = -1;
            StringBuilder chooseText = new StringBuilder();
          
            chooseText.AppendLine(playerPick.TenetAbilities.Count()==0 ? "Was ist deine erste Fähigkeit?" : "Was ist deine zweite Fähigkeit?");

            bool isValidAbilityId = false;

            while (!isValidAbilityId)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < currentTenet.Abilities.Count(); i++)
                {
                    Console.WriteLine($"{i} für {currentTenet.Abilities[i].Name}");
                }

                isValidAbilityId = IsValidInput(currentTenet.Abilities.Count, out tenetAbilityID);

                if (isValidAbilityId)
                {
                    playerPick.TenetAbilities.Add(currentTenet.Abilities[tenetAbilityID]);
                }
            }
        }

    }
}
