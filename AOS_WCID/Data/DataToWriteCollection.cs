using AOS_WCID.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private List<Entities.Hero> _herolist; 
        private List<CommandTrait> _commandTraitList;


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
        public List<Entities.Hero> Herlist { get => _herolist; set => _herolist = value; }
        public List<CommandTrait> CommandTraitList { get => _commandTraitList; set => _commandTraitList = value; }

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
                " model." }, "A Celestian Vortex is a single model.", new List<string>{"ENDLESS SPELL", "AZYR", "CELESTIAN VORTEX"}),
                new EndlessSpell("EVERBLAZE COMET",0, "Summon Everblaze Comet: Reaching an\r\narm to the heavens, the wizard calls" +
                " down a\r\npure comet of Azyrite energy. Radiating the\r\npure light of Sigmar’s realm, it crashes into\r\nthe foe’s " +
                "ranks with devastating effect.\r\nSummon Everblaze Comet has a casting\r\nvalue of 6. Only Stormcast Eternal\r\nWizards" +
                " can attempt to cast this spell. If\r\nsuccessfully cast, set up an Everblaze Comet\r\nmodel wholly within 36\" " +
                "of the caster.", "", new List<string>{"Burning Vengeance: An Everblaze Comet\r\nsmashes into " +
                "the battlefield with tremendous\r\nforce, whereupon it embeds itself into\r\nthe ground, " +
                "radiating a corona of deadly\r\nAzyrite energies.\r\nAfter this model is set up, roll a dice" +
                " for each\r\nunit within 10\" of this model. On a 1-2, that\r\nunit suffers 1 mortal wound." +
                " On a 3-4, that\r\nunit suffers D3 mortal wounds. On a 5-6,\r\nthat unit suffers 3 mortal" +
                " wounds.\r\nIn addition, at the start of each battle round,\r\nroll a dice for each unit" +
                " within 5\" of this\r\nmodel. On a 1-3, that unit suffers 1 mortal\r\nwound. On a 4-6, that" +
                " unit suffers D3\r\nmortal wounds.", "Arcane Disruption: The emanations from\r\nan Everblaze" +
                " Comet disrupt the arcane\r\nabilities of nearby wizards.\r\nSubtract 1 from casting rolls" +
                " for Wizards\r\nwhile they are within 5\" of this model."}, "An Everblaze Comet is a single model.", new List<string>{"ENDLESS SPELL", "AZYR", "EVERBLAZE COMET"})
            };
            _herolist = new List<Entities.Hero>()
            {
                new Entities.Hero("Yndrasta", 12, 3, 10, 8, 1, 280, new List<string>(){"ORDER", "STORMCAST ETERNALS", "THUNDERSTRIKE", "HERO", "YNDRASTA", "SINGLE", "UNIQUE" }, new List<Attack>(){ new Attack("" +
                "Thengavar", 2, 2, 2, "D6", 1, 18, false), new Attack("Blade of the High Heavens", 3, 2, 2, "3", 4,1, true ) }, new List<string>(){ "The Prime Huntress: " +
                "If any enemy MONSTERS are within 3\" of this unit, add 10 to the number of wounds suffered by those MONSTERS when determining which row on their damage table to use.", "Champion of Sigmar" +
                ":This unit has a 4+ ward.", "Dazzling Radiance:Once per turn in your hero phase, if this unit is on the battlefield, you can return 1 slain model to each friendly STORMCAST ETERNALS unit" +
                " with a Wounds characteristic of 3 or less that is wholly within 12\" of this unit.", "Hawk of the Celestial Skies: Do not take battleshock tests for friendly STORMCAST ETERNALS and " +
                "CITIES OF SIGMAR units wholly within 12\" of this unit." } ),
                new Entities.Hero("Knight Arcanum", 5, 3, 8, 6, 1, 110, new List<string>(){"SINGLE","ORDER", "STORMCAST ETERNALS", "THUNDERSTRIKE", "HERO", "WIZARD", "KNIGHT", "" +
                "KNIGHT-ARCANUM"}, new List<Attack>(){new Attack("Valedictor’s Stave", 3 , 4, 1, "D3", 3, 2, true) }, new List<string>(){ "Indomitable Loreseekers:Predatory endless spells cannot pass across this unit" +
                " or finish a move within 3\" of this unit.", "Blaze of the Heavens: Blaze of the Heavens is a spell that has a casting value of 7 and a range of 18\". If successfully cast, pick 1 enemy unit within " +
                "range and visible to the caster. That unit suffers D3 mortal wounds. Add 2\" to the range of this spell for each other friendly STORMCAST ETERNALS THUNDERSTRIKE unit wholly within 12\" of the caster." } ),
                new Entities.Hero("Celestan Prime", 12, 3, 10, 8, 1, 330, new List<string>(){"SINGLE", "UNIQUE","ORDER", "STORMCAST ETERNALS", "HERO", "CELESTANT-PRIME"}, new List<Attack>(){new Attack("Ghal Maraz",3,2,3,"3",3, 2, true)}, new List<string>(){"" +
                "Cometstrike Sceptre: In your shooting phase, you can pick 1 point on the battlefield within 24\" of this unit and visible to it. Each enemy unit within 3\" of that point " +
                "suffers D3 mortal wounds.", "Retribution from On High: Instead of setting up this unit on the battlefield, you can place it to one side and say that it is set up in " +
                "the heavens as a reserve unit. If you do so, at the end of your movement phase, you must say if this unit will remain in reserve or if it will strike from the " +
                "heavens.\r\n\r\nAt the end of your movement phase, if this unit remains in reserve, add 2 to the Attacks characteristic of this unit’s Ghal Maraz for the rest of" +
                " the battle. If this unit strikes from the heavens, set this unit up on the battlefield more than 9\" from all enemy units.\r\n", "Orrery of Celestial Fates: " +
                "Once per turn, before you make a hit or wound roll for an attack made by this unit, a save roll for an attack that targets this unit, or a run or charge roll " +
                "for this unit, you can say that you will foresee the result of the roll. If you do so, instead of making the roll, you must choose the result of the roll." +
                " The result chosen for a D6 roll must be a whole number from 1 to 6, and the result chosen for a 2D6 roll must be a whole number from 2 to 12. The result " +
                "cannot be re-rolled, but any modifiers are applied to it as normal.", "Eye of the Celestial Storm: This unit has a ward of 4+." })
            };
            DataManager.WriteHeroListJsonToPath(_herolist);
            _commandTraitList = new List<CommandTrait>()
            {
                new CommandTrait("Master of Magic", "nce per hero phase, you can re-roll one casting roll, dispelling roll or unbinding roll for this general."),
                new CommandTrait("Battle-lust", "You can re-roll run rolls and charge rolls for this general.")
            };
 
        }
    }
}
