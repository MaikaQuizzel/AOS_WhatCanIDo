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
        private int gameMode;
        private string gameName ="";
        private int allianceID;
        private int factionID;
        private int subfactionID;
        private GrandAlliance grandAlliance;
        private Faction faction;
        private Subfaction subfaction;
        private List<GrandAlliance> alliancesList;
        private List<Faction> factionsList;
        private List<Subfaction> subfactionList;
        private List<Unit> armyList;

        public void StartGame()
        {
            InitializeStuff();
            //TestJSON();
            EingabeGameMode();
            EingabeGrandAlliance();
            EingabeFaction();
            EingabeSubfaction();
        }

        private void InitializeStuff()
        {
            //Dummy Data 
            alliancesList = new List<GrandAlliance>() {
                 new GrandAlliance("Order"),
                 new GrandAlliance("Chaos"),
                 new GrandAlliance("Death"),
                 new GrandAlliance("Destruction")
            };

            factionsList = new List<Faction>() {
                new Faction("Stormcast Eternals", alliancesList.FirstOrDefault(x => x.Name.Equals("Order"))),
                new Faction("Seraphon", alliancesList.FirstOrDefault(x => x.Name.Equals("Order"))),
                new Faction("Discipiles od Tzeentch", alliancesList.FirstOrDefault(x => x.Name.Equals("Chaos"))),
                new Faction("Skaven", alliancesList.FirstOrDefault(x => x.Name.Equals("Chaos"))),
                new Faction("Nighthaunt", alliancesList.FirstOrDefault(x => x.Name.Equals("Death"))),
                new Faction("Flesh-Eater Courts", alliancesList.FirstOrDefault(x => x.Name.Equals("Death"))),
                new Faction("Gloomspite Glitz", alliancesList.FirstOrDefault(x => x.Name.Equals("Destruction"))),
                new Faction("Sons of Behemat", alliancesList.FirstOrDefault(x => x.Name.Equals("Destruction")))
            };

            subfactionList = new List<Subfaction>() {
                new Subfaction("Atral Templars","Friendly ASTRAL TEMPLARS units cannot be picked when your opponent carries out a monstrous rampage." , factionsList.FirstOrDefault(x=> x.FactionName.Equals("Stormcast Eternals"))),
                new Subfaction("No Subfaction", "", factionsList.FirstOrDefault(x=> x.FactionName.Equals("Stormcast Eternals"))),
                new Subfaction("Hollowed Knights", "If a friendly HALLOWED KNIGHTS REDEEMER model is slain within 3inc of any enemy units, roll a dice. On a 4+, that model can fight before it is removed from play.", factionsList.FirstOrDefault(x=> x.FactionName.Equals("Stormcast Eternals")))
            };

            //
        }


         public void EingabeGameMode()
        {
            bool validEntry = false;
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
            while (!validEntry)
            {
                Console.WriteLine("Welche Alliance willst du spielen");
                int num = 0;
                foreach (GrandAlliance i in alliancesList)
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
                    grandAlliance= alliancesList[allianceID];
                    Console.WriteLine($"Du hast {grandAlliance.Name} gewählt");
                }
            }
        }
        void EingabeFaction() 
        {
            bool validEntry=false;
            while (!validEntry)
            {
                Console.WriteLine("Welche Fraktion möchtest du spielen?");
                int num =0;
                foreach(Faction i in factionsList)
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
                    faction = factionsList[factionID];
                    Console.WriteLine($"Du hast {faction.FactionName} als Fraktion gewählt");
                }
            }
        }
        void EingabeSubfaction() 
        {
            bool validEntry = false;
            while (!validEntry)
            {
                Console.WriteLine("Welche Subfrakion möchtest du spielen?");
                int num = 0;
                foreach (Subfaction i in subfactionList)
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
                    subfaction = subfactionList[subfactionID];
                    Console.WriteLine($"Du hast {subfaction.Name} als Subraktion gewählt");
                }
            }

        }
        void TestJSON()
        {
            var testJsonAlliance = JsonSerializer.Serialize(alliancesList);
            var testJsonfaction = JsonSerializer.Serialize(factionsList);   
            var testJsonSubfaction = JsonSerializer.Serialize(subfactionList);

        }
    }
}
