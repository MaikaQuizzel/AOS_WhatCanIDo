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
        private string gameName ="";
        private GrandAlliance grandAlliance;
        private Faction faction;
        private Subfaction subfaction;
        private Batallion batallion;
        private List<Unit> armyList;

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
                    if (gameMode == 1) { gameName = "Path to Glory"; }
                    if (gameMode == 2) { gameName = "Normal"; }
                    Console.WriteLine($"Du hast {gameName} gewählt.");
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
                    grandAlliance= initialStuff.AlliancesList[allianceID];
                    Console.WriteLine($"Du hast {grandAlliance.Name} gewählt");
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
                    faction = initialStuff.FactionsList[factionID];
                    Console.WriteLine($"Du hast {faction.FactionName} als Fraktion gewählt");
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
                    subfaction = initialStuff.SubfactionList[subfactionID];
                    Console.WriteLine($"Du hast {subfaction.Name} als Subraktion gewählt");
                    if (gameName == "Path to Glory" && subfaction.Name == "No Subfaction")
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
