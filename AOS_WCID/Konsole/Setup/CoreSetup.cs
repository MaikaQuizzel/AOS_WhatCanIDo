﻿using AOS_WCID.Data;
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
        
        private DataProvider initialStuff;

        public DataProvider InitialStuff { get => initialStuff; set => initialStuff = value; }

        public CoreSetup( DataProvider initStuff)
        {
            initialStuff = initStuff;
            consolenReader = new ConsolenReader();
        }

        

        public void EingabeGameMode()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.Append("Which Gamemode do you want to play?");
            chooseText.AppendLine("\n 0 for Path to Glory \n 1 for normal");

            int gameMode = -1;

            while (gameMode != 0 && gameMode != 1)
            {
                Console.WriteLine(chooseText.ToString());
                
                IsValidInput(new List<int> { 0, 1 }, out gameMode);

                if (gameMode == 0 || gameMode == 1)
                {
                    PlayerPicks.Instance.GameName = gameMode == 0 ? StringConstants.GAMEMODEPATH : "Normal";
                    Console.WriteLine($"You picked {PlayerPicks.Instance.GameName}.");
                    continue;
                }
                Console.WriteLine("Enter \" 0\" or \" 1\" ");
            }
            ConsoleSpacer.PrintSpacer();
        }

        public void EingabeGrandAlliance()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.AppendLine("Which Alliance do you want to play?");
            int listCount = initialStuff.AlliancesList.Count();
            int allianceID=-1;

            while (!IsValidGrandAlliance(allianceID, listCount))
            {
                Console.WriteLine(chooseText.ToString());

                for (int i = 0; i < listCount; i++)
                {
                    Console.WriteLine($"{i} for {initialStuff.AlliancesList[i].Name}");
                }

                int.TryParse(consolenReader.GetLine(), out allianceID);
                
                if (IsValidGrandAlliance(allianceID, listCount))
                {
                    PlayerPicks.Instance.GrandAlliance = initialStuff.AlliancesList[allianceID];
                    Console.WriteLine($"You picked {PlayerPicks.Instance.GrandAlliance.Name}.");
                }
            }
            ConsoleSpacer.PrintSpacer();
        }
        private static bool IsValidGrandAlliance(int allianceID, int listCount) 
        {
            return allianceID >= 0 && allianceID < listCount;
        }

        public void EingabeFaction()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.AppendLine("Which faction do you want to play?");

            int factionID= -1;
            int factionCount = initialStuff.FactionsList.Count();

            while (!IsValidFaction(factionID, factionCount))
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < factionCount; i++)
                {
                    Console.WriteLine($"{i} for {initialStuff.FactionsList[i].FactionName}");
                }

                int.TryParse(consolenReader.GetLine(), out factionID);
            }
            PlayerPicks.Instance.Faction = initialStuff.FactionsList[factionID];
            Console.WriteLine($"You picked {PlayerPicks.Instance.Faction.FactionName} as a faction");
            ConsoleSpacer.PrintSpacer();    
        }
        private static bool IsValidFaction(int factionID, int listCount) 
        {
            return factionID >= 0 && factionID < listCount;
        }
        public void EingabeSubfaction()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.AppendLine("Which Subfaction do you want to play?");

            int subfactionCount = initialStuff.SubfactionList.Count();
            int subfactionID = -1;

            while (!IsValidSubfaction(subfactionID,subfactionCount))
            {
                Console.WriteLine(chooseText.ToString());
                int num = 0;
                for (int i = 0; i < subfactionCount; i++)
                {
                    Console.WriteLine($"{i} for {initialStuff.SubfactionList[i].Name}.");
                }

                int.TryParse(consolenReader.GetLine(), out subfactionID);

                if (!IsValidSubfaction(subfactionID, subfactionCount))
                    continue;

                PlayerPicks.Instance.Subfaction = initialStuff.SubfactionList[subfactionID];
                Console.WriteLine($"You picked {PlayerPicks.Instance.Subfaction.Name} as a Subfraction");
                ConsoleSpacer.PrintSpacer();

            }
            if (NeedsCustomSubfaction())
             {
                PickTenet();
                initialStuff.TenetList.Remove(PlayerPicks.Instance.Tenets[0]);
                PickTenetAbillity();
                PickTenet();
                PickTenetAbillity();

            }
            ConsoleSpacer.PrintSpacer();
        }
        public static bool IsValidSubfaction(int subfactionID, int subfactionCount)
        {
            return subfactionID >= 0 && subfactionID < subfactionCount;
        }
        public static bool NeedsCustomSubfaction()
        {
            return PlayerPicks.Instance.GameName.Equals(StringConstants.GAMEMODEPATH) && PlayerPicks.Instance.Subfaction.Name.Equals(StringConstants.NOSUBFACTION);
        }
       

        public void PickTenet() 
        {
            StringBuilder chooseText = new StringBuilder();
            
            chooseText.AppendLine(PlayerPicks.Instance.Tenets.Count()==0 ? "What is your first Tenat?" : "What is your second Tenat?") ;

            int tenetID = -1;
            
            int tenetCount = initialStuff.TenetList.Count();
            bool isValidTenet = false;

            while (!isValidTenet)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < tenetCount; i++)
                {
                    Console.WriteLine($"{i} for {initialStuff.TenetList[i].Name}");
                }
                isValidTenet = IsValidInput(tenetCount, out tenetID);
            }
            PlayerPicks.Instance.Tenets.Add( initialStuff.TenetList[tenetID]);
            ConsoleSpacer.PrintSpacer();
        }

        public void PickTenetAbillity()
        {
            Tenets currentTenet = PlayerPicks.Instance.Tenets.Last();
            int tenetAbilityID = -1;
            StringBuilder chooseText = new StringBuilder();
          
            chooseText.AppendLine(PlayerPicks.Instance.TenetAbilities.Count()==0 ? "What is your first ability?" : "What is your second ability?");

            bool isValidAbilityId = false;

            while (!isValidAbilityId)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < currentTenet.Abilities.Count(); i++)
                {
                    Console.WriteLine($"{i} for {currentTenet.Abilities[i].Name}");
                }

                isValidAbilityId = IsValidInput(currentTenet.Abilities.Count, out tenetAbilityID);

                if (isValidAbilityId)
                {
                    PlayerPicks.Instance.TenetAbilities.Add(currentTenet.Abilities[tenetAbilityID]);
                }
            }
            ConsoleSpacer.PrintSpacer();
        }

    }
}
