using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOS_WCID;
using System.Text.Json;

namespace AOS_WCID
{
    public class Main
    {
        private PlayerPicks playerPick;
        private InitialStuff initialStuff;


        public void StartGame()
        {
            initialStuff = new InitialStuff();
            initialStuff.InitializeStuff();

            playerPick = new PlayerPicks();

            EingabeGameMode();
            EingabeGrandAlliance();
            EingabeFaction();
            EingabeSubfaction();
        }

       


         public void EingabeGameMode()
        {
            bool validEntry = false;
            int gameMode;
            while (!validEntry) 
            {
                Console.WriteLine("Für welchen Spielmodus möchtest du erstellen");
                Console.WriteLine("1 für Path to Glory \n 2 für normal");

                ConsolenReader reader = new ConsolenReader();
                string consoleEingabe = "2";
                consoleEingabe = reader.GetLine();
                int.TryParse(consoleEingabe, out gameMode);
                validEntry = gameMode == 1 || gameMode == 2;
                if (!validEntry) { Console.WriteLine("\" 1\" oder \" 2\" eingeben"); }
                if (validEntry) {
                    if (gameMode == 1) { playerPick.GameName = "Path to Glory"; }
                    if (gameMode == 2) { playerPick.GameName = "Normal"; }
                    Console.WriteLine($"Du hast {playerPick.GameName} gewählt.");
                }
                
            }
            
        }
        void EingabeGrandAlliance() {
            bool validEntry = false;
            int allianceID;
            while (!validEntry)
            {
                Console.WriteLine("Welche Alliance willst du spielen");
                int num = 0;
                foreach (GrandAlliance i in initialStuff.AlliancesList)
                {
                    Console.WriteLine($"{num} für {i}");
                    num++;
                }
                ConsolenReader reader = new ConsolenReader();
                string eingabe = reader.GetLine();
                int.TryParse(eingabe, out allianceID);
                validEntry = allianceID >= 0 && allianceID <= num;
                if (!validEntry) { Console.WriteLine($"Wähle zwischen 0 und {num}."); }
                if (validEntry) 
                {
                    playerPick.GrandAlliance = initialStuff.AlliancesList[allianceID];
                    Console.WriteLine($"Du hast {playerPick.GrandAlliance.Name} gewählt");
                }
            }
        }
        void EingabeFaction() 
        {
            bool validEntry=false;
            int factionID;
            while (!validEntry)
            {
                Console.WriteLine("Welche Fraktion möchtest du spielen?");
                int num =0;
                foreach(Faction i in initialStuff.FactionsList)
                {
                    Console.WriteLine($"{num} für {i.FactionName}.");
                }
                ConsolenReader reader = new ConsolenReader();
                string eingabe = reader.GetLine();
                int.TryParse(eingabe,out factionID);
                validEntry= factionID >= 0 && factionID <= num;
                if (!validEntry) { Console.WriteLine($"Wähle zwischen 0 und {num}."); }
                if (validEntry)
                {
                    playerPick.Faction = initialStuff.FactionsList[factionID];
                    Console.WriteLine($"Du hast {playerPick.Faction.FactionName} als Fraktion gewählt");
                }
            }
        }
        void EingabeSubfaction() 
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
        void CustomSubfaction() {
            Console.WriteLine("Eye of the Storm und Celestial Radiance");            
        }
        void EingabeGeneral() { }
        void EingabeUnits() { }
        void HeroPick() { }
        void BattlelinePick() { }
        void AttelleryPick() { }
        void EndlessSpellPick() { }
        void OtherPick() { }
        void EingabeBattallion() { }
    }
}
