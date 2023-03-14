using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOS_WCID.Entities;

namespace AOS_WCID.Data
{
    public class InitialStuff
    {
        private List<GrandAlliance> alliancesList;
        private List<Faction> factionsList;
        private List<Subfaction> subfactionList;
        private List<Tenets> tenetList;
        private List<TenetAbility> tenetAbilityListHammer;
        private List<TenetAbility> tenetAbilityListShield;
        private List<TenetAbility> tenetAbilityListTempest;


        public InitialStuff() { }

        public List<GrandAlliance> AlliancesList { get => alliancesList; set => alliancesList = value; }
        public List<Faction> FactionsList { get => factionsList; set => factionsList = value; }
        public List<Subfaction> SubfactionList { get => subfactionList; set => subfactionList = value; }
        public List<Tenets> TenetList { get => tenetList; set => tenetList = value; }
        public List<TenetAbility> TenetAbilityListHammer { get => tenetAbilityListHammer; set => tenetAbilityListHammer = value; }
        public List<TenetAbility> TenetAbilityListShield { get => tenetAbilityListShield; set => tenetAbilityListShield = value; }
        public List<TenetAbility> TenetAbilityListTempest { get => tenetAbilityListTempest; set => tenetAbilityListTempest = value; }

        public void InitializeStuff()
        {
            //Dummy Data 
            alliancesList = new List<GrandAlliance>() {
                 new GrandAlliance("Order")
            };

            FactionsList = new List<Faction>() {
                new Faction("Stormcast Eternals", alliancesList.FirstOrDefault(x => x.Name.Equals("Order")))
            };

            SubfactionList = new List<Subfaction>() {
                new Subfaction("Atral Templars","Friendly ASTRAL TEMPLARS units cannot be picked when your opponent carries out a monstrous rampage." , FactionsList.FirstOrDefault(x=> x.FactionName.Equals("Stormcast Eternals"))),
                new Subfaction("No Subfaction", "", FactionsList.FirstOrDefault(x=> x.FactionName.Equals("Stormcast Eternals"))),
                new Subfaction("Hollowed Knights", "If a friendly HALLOWED KNIGHTS REDEEMER model is slain within 3inc of any enemy units, roll a dice. On a 4+, that model can fight before it is removed from play.", FactionsList.FirstOrDefault(x=> x.FactionName.Equals("Stormcast Eternals")))
            };
            TenetList = new List<Tenets>() {
                new Tenets("Tenates of the Hammer", TenetAbilityListHammer),
                new Tenets("Tenates of the Shield", TenetAbilityListShield),
                new Tenets("Tenates of the Tempest", TenetAbilityListTempest)
            };
            TenetAbilityListHammer = new List<TenetAbility>() {
                new TenetAbility("Beast Hunter","Add +1 to hit against monsters."),
                new TenetAbility("Champion Warriors","Add +1 to hit against heros.")
            };
            TenetAbilityListShield = new List<TenetAbility>() {
                new TenetAbility("Celestial Radiance","+6 Ward save."),
                new TenetAbility("Here we stand","Rerole Bravery test.")
            };
            TenetAbilityListTempest = new List<TenetAbility>() {
                new TenetAbility("Eye of the Storm","Enemies can not fall back during combat."),
                new TenetAbility("Master of Heavenly Lore","Rerole 1s on casting rolls")
            };


            //
        }
    }
}
