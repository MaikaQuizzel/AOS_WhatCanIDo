using AOS_WCID.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Data
{
    public class DataToWriteCollection
    {
        private List<GrandAlliance> alliancesList;
        private List<Faction> factionsList;
        private List<Subfaction> subfactionList;
        private List<Tenets> tenetList;
        private List<TenetAbility> tenetAbilityListHammer;
        private List<TenetAbility> tenetAbilityListShield;
        private List<TenetAbility> tenetAbilityListTempest;
        private List<Batallion> batallionList;
        private List<EndlessSpell> endlessSpellList;


        public DataToWriteCollection() { }

        public List<GrandAlliance> AlliancesList { get => alliancesList; set => alliancesList = value; }
        public List<Faction> FactionsList { get => factionsList; set => factionsList = value; }
        public List<Subfaction> SubfactionList { get => subfactionList; set => subfactionList = value; }
        public List<Tenets> TenetList { get => tenetList; set => tenetList = value; }
        public List<TenetAbility> TenetAbilityListHammer { get => tenetAbilityListHammer; set => tenetAbilityListHammer = value; }
        public List<TenetAbility> TenetAbilityListShield { get => tenetAbilityListShield; set => tenetAbilityListShield = value; }
        public List<TenetAbility> TenetAbilityListTempest { get => tenetAbilityListTempest; set => tenetAbilityListTempest = value; }
        public List<Batallion> BatallionList { get => batallionList; set => batallionList = value; }
        public List<EndlessSpell> EndlessSpellList { get => endlessSpellList; set => endlessSpellList = value; }

        public void WriteStuffNow()
        {
            //Dummy Data 
            alliancesList = new List<GrandAlliance>() {
                 new GrandAlliance("Order")
            };
            DataManager.WriteGrandAllianceJsonToPath(AlliancesList);

            FactionsList = new List<Faction>() {
                new Faction("Stormcast Eternals", alliancesList.FirstOrDefault(x => x.Name.Equals("Order")))
            };
            DataManager.WriteFactionsJsonToPath(FactionsList);

            SubfactionList = new List<Subfaction>() {
                new Subfaction("Atral Templars","Friendly ASTRAL TEMPLARS units cannot be picked when your opponent carries out a monstrous rampage." , FactionsList.FirstOrDefault(x=> x.FactionName.Equals("Stormcast Eternals"))),
                new Subfaction("No Subfaction", "", FactionsList.FirstOrDefault(x=> x.FactionName.Equals("Stormcast Eternals"))),
                new Subfaction("Hollowed Knights", "If a friendly HALLOWED KNIGHTS REDEEMER model is slain within 3inc of any enemy units, roll a dice. On a 4+, that model can fight before it is removed from play.", FactionsList.FirstOrDefault(x=> x.FactionName.Equals("Stormcast Eternals")))
            };
            DataManager.WriteSubfactionListJsonToPath(SubfactionList);

            TenetAbilityListHammer = new List<TenetAbility>() {
                new TenetAbility("Beast Hunter","Add +1 to hit against monsters."),
                new TenetAbility("Champion Warriors","Add +1 to hit against heros.")
            };
            DataManager.WriteHammerAbilitiesListJsonToPath(TenetAbilityListHammer);
            TenetAbilityListShield = new List<TenetAbility>() {
                new TenetAbility("Celestial Radiance","+6 Ward save."),
                new TenetAbility("Here we stand","Rerole Bravery test.")
            };
            DataManager.WriteShiedAbilitiesListJsonToPath(TenetAbilityListShield);
            TenetAbilityListTempest = new List<TenetAbility>() {
                new TenetAbility("Eye of the Storm","Enemies can not fall back during combat."),
                new TenetAbility("Master of Heavenly Lore","Rerole 1s on casting rolls")
            };
            DataManager.WriteTempestAbilitiesListJsonToPath(TenetAbilityListTempest);

            TenetList = new List<Tenets>() {
                new Tenets("Tenates of the Hammer", TenetAbilityListHammer),
                new Tenets("Tenates of the Shield", TenetAbilityListShield),
                new Tenets("Tenates of the Tempest", TenetAbilityListTempest)
            };
            DataManager.WriteTenetsJsonToPath(TenetList);
            batallionList = new List<Batallion>
            {
                new Batallion("No Batallion", "", 1,0,1,0,0),
                new Batallion("Battle Regiment","One-drop Deployment", 1,0,1,0,0),
                new Batallion("Linebreaker", "Once per battle, 1 unit from this batallion can receive the All-out Attack or All-out Defence command without the comman being issued and without a point beeing spend.", 1,0,0,2,0)
            };
            DataManager.WriteBatallionListJsonToPath(batallionList);
            endlessSpellList = new List<EndlessSpell>()
            {
                new EndlessSpell("CELESTIAN VORTEX",0,"Summon Celestian Vortex: The wizard\r\ncasts a pair of ensorcelled hammers into the\r\nair, which begin to spin. " +
                "As the vortex gets\r\nmore intense, the hammers multiply to form\r\na maelstrom of skull-crushing force.\r\n" +
                "Summon Celestian Vortex has a casting\r\nvalue of 6. Only Stormcast Eternal\r\nWizards can attempt to cast this " +
                "spell. If\r\nsuccessfully cast, set up a Celestian Vortex\r\nmodel wholly within 12\" of the caster.","A Celestian Vortex is a\r\npredatory endless spell. " +
                "A Celestian Vortex\r\ncan move up to 8\" and can fly.0", new List<string>{"Swirling Doom: When a Celestian Vortex is\r\nsummoned, it immediately swirls " +
                "across the\r\nbattlefield leaving devastation in its wake.\r\nWhen this model is set up, the player who set\r\nit up can immediately make a move with" +
                " it.","Storm of Vengeance: Those caught in this\r\ndeadly maelstrom find themselves battered\r\nby magical hammers" +
                " and crushed by furious\r\nAzyrite energy.\r\nAfter moving this model, you can pick 1\r\nenemy unit within 1\" " +
                "of this model and roll\r\n12 dice. For each roll of 6+, that unit suffers 1\r\nmortal wound. If the unit being rolled" +
                " for is\r\na Chaos unit, it suffers 1 mortal wound for\r\neach roll of 5+ instead.","Tornado of Magic: A " +
                "Celestian Vortex whips\r\nthe air around it into a tornado that disrupts\r\nattacks made with missile weapons." +
                "\r\nSubtract 1 from hit rolls for attacks made\r\nwith missile weapons by units while they are\r\nwithin 6\" of this" +
                " model." }, "A Celestian Vortex is a single model.", new List<string>{"ENDLESS SPELL", "AZYR", "CELESTIAN VORTEX"})
                //new EndlessSpell()
            };

        }
    }
}
