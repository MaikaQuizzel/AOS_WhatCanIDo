﻿using AOS_WCID.Entities;
using AOS_WCID.Entities.Interfaces;
using AOS_WCID.Entities.NewFolder;
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
        private EndlessSpellList endlessSpellList;
        private HeroesList _herolist = new HeroesList();
        private List<CommandTrait> _commandTraitList;
        private List<Spell> _spellList;
        private List<Prayer> _prayerList;
        private List<Artefact> _artefactList;
        private UnitList _units = new UnitList();
        private List<Reactions> _reactionsList;


        public DataToWriteCollection() { }

        public List<GrandAlliance> AlliancesList { get => alliancesList; set => alliancesList = value; }
        public List<Faction> FactionsList { get => factionsList; set => factionsList = value; }
        public List<Subfaction> SubfactionList { get => subfactionList; set => subfactionList = value; }
        public List<Tenets> TenetList { get => tenetList; set => tenetList = value; }
        public List<TenetAbility> TenetAbilityListHammer { get => tenetAbilityListHammer; set => tenetAbilityListHammer = value; }
        public List<TenetAbility> TenetAbilityListShield { get => tenetAbilityListShield; set => tenetAbilityListShield = value; }
        public List<TenetAbility> TenetAbilityListTempest { get => tenetAbilityListTempest; set => tenetAbilityListTempest = value; }
        public List<Batallion> BatallionList { get => batallionList; set => batallionList = value; }
        public EndlessSpellList EndlessSpellList { get => endlessSpellList; set => endlessSpellList = value; }
        public HeroesList Herolist { get => _herolist; set => _herolist = value; }
        public List<CommandTrait> CommandTraitList { get => _commandTraitList; set => _commandTraitList = value; }
        public List<Spell> SpellList { get => _spellList; set => _spellList = value; }
        public List<Prayer> PrayerList { get => _prayerList; set => _prayerList = value; }
        public List<Artefact> ArtefactList { get => _artefactList; set => _artefactList = value; }
        public UnitList Units { get => _units; set => _units = value; }
        public List<Reactions> ReactionsList { get => _reactionsList; set => _reactionsList = value; }

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
            var endliess = new List<IESpell>()
            {
                new EndlessSpell("CELESTIAN VORTEX",0,"Summon Celestian Vortex: The wizard\r\ncasts a pair of ensorcelled hammers into the\r\nair, which begin to spin. " +
                "As the vortex gets\r\nmore intense, the hammers multiply to form\r\na maelstrom of skull-crushing force.\r\n" +
                "Summon Celestian Vortex has a casting\r\nvalue of 6. Only Stormcast Eternal\r\nWizards can attempt to cast this " +
                "spell. If\r\nsuccessfully cast, set up a Celestian Vortex\r\nmodel wholly within 12\" of the caster.","A Celestian Vortex is a\r\npredatory endless spell. " +
                "A Celestian Vortex\r\ncan move up to 8\" and can fly.0", new List<Ability>{new Ability( "Swirling Doom: When a Celestian Vortex is\r\nsummoned, it immediately swirls " +
                "across the\r\nbattlefield leaving devastation in its wake.\r\nWhen this model is set up, the player who set\r\nit up can immediately make a move with" +
                " it."),new Ability("Storm of Vengeance: Those caught in this\r\ndeadly maelstrom find themselves battered\r\nby magical hammers" +
                " and crushed by furious\r\nAzyrite energy.\r\nAfter moving this model, you can pick 1\r\nenemy unit within 1\" " +
                "of this model and roll\r\n12 dice. For each roll of 6+, that unit suffers 1\r\nmortal wound. If the unit being rolled" +
                " for is\r\na Chaos unit, it suffers 1 mortal wound for\r\neach roll of 5+ instead."),new Ability("Tornado of Magic: A " +
                "Celestian Vortex whips\r\nthe air around it into a tornado that disrupts\r\nattacks made with missile weapons." +
                "\r\nSubtract 1 from hit rolls for attacks made\r\nwith missile weapons by units while they are\r\nwithin 6\" of this" +
                " model." )}, "A Celestian Vortex is a single model.", new List<string>{"ENDLESS SPELL", "AZYR", "CELESTIAN VORTEX"}),
                new EndlessSpell("EVERBLAZE COMET",0, "Summon Everblaze Comet: Reaching an\r\narm to the heavens, the wizard calls" +
                " down a\r\npure comet of Azyrite energy. Radiating the\r\npure light of Sigmar’s realm, it crashes into\r\nthe foe’s " +
                "ranks with devastating effect.\r\nSummon Everblaze Comet has a casting\r\nvalue of 6. Only Stormcast Eternal\r\nWizards" +
                " can attempt to cast this spell. If\r\nsuccessfully cast, set up an Everblaze Comet\r\nmodel wholly within 36\" " +
                "of the caster.", "", new List<Ability>{new Ability("Burning Vengeance: An Everblaze Comet\r\nsmashes into " +
                "the battlefield with tremendous\r\nforce, whereupon it embeds itself into\r\nthe ground, " +
                "radiating a corona of deadly\r\nAzyrite energies.\r\nAfter this model is set up, roll a dice" +
                " for each\r\nunit within 10\" of this model. On a 1-2, that\r\nunit suffers 1 mortal wound." +
                " On a 3-4, that\r\nunit suffers D3 mortal wounds. On a 5-6,\r\nthat unit suffers 3 mortal" +
                " wounds.\r\nIn addition, at the start of each battle round,\r\nroll a dice for each unit" +
                " within 5\" of this\r\nmodel. On a 1-3, that unit suffers 1 mortal\r\nwound. On a 4-6, that" +
                " unit suffers D3\r\nmortal wounds."), new Ability("Arcane Disruption: The emanations from\r\nan Everblaze" + 
                " Comet disrupt the arcane\r\nabilities of nearby wizards.\r\nSubtract 1 from casting rolls" + 
                " for Wizards\r\nwhile they are within 5\" of this model.") }, "An Everblaze Comet is a single model.",
                new List<string>{"ENDLESS SPELL", "AZYR", "EVERBLAZE COMET"})
            };
            endlessSpellList = new EndlessSpellList();
            endlessSpellList._endlessSpellList = endliess;
            DataManager.WriteEndlessSpellsListJsonToPath(endlessSpellList);

             List<Hero> heroes = new List<Hero>()
             {
                 new Hero("Yndrasta", 12, 3, 10, 8, 1, 280, new List<string>() { "ORDER", "STORMCAST ETERNALS", "THUNDERSTRIKE", "HERO", "YNDRASTA", "SINGLE", "UNIQUE" }, new List<Attack>(){ new Attack("" +
                "Thengavar", 2, 2, 2, "D6", "1", 18, false), new Attack("Blade of the High Heavens", 3, 2, 2, "3", "4",1, true ) }, new List<Ability>(){ new Ability("The Prime Huntress: " +
                "If any enemy MONSTERS are within 3\" of this unit, add 10 to the number of wounds suffered by those MONSTERS when determining which row on their damage table to use."), new Ability( "Champion of Sigmar" +
                ":This unit has a 4+ ward."), new Ability( "Dazzling Radiance:Once per turn in your hero phase, if this unit is on the battlefield, you can return 1 slain model to each friendly STORMCAST ETERNALS unit" +
                " with a Wounds characteristic of 3 or less that is wholly within 12\" of this unit."),new Ability( "Hawk of the Celestial Skies: Do not take battleshock tests for friendly STORMCAST ETERNALS and " +
                "CITIES OF SIGMAR units wholly within 12\" of this unit." )}),
                 new Entities.Hero("Knight Arcanum", 5, 3, 8, 6, 1, 110, new List<string>(){"SINGLE","ORDER", "STORMCAST ETERNALS", "THUNDERSTRIKE", "HERO", "WIZARD", "KNIGHT", "" +
                 "KNIGHT-ARCANUM"}, new List<Attack>(){new Attack("Valedictor’s Stave", 3 , 4, 1, "D3", "3", 2, true) }, new List<Ability>(){new Ability( "Indomitable Loreseekers:Predatory endless spells cannot pass across this unit" +
                 " or finish a move within 3\" of this unit."), new Ability( "Blaze of the Heavens: Blaze of the Heavens is a spell that has a casting value of 7 and a range of 18\". If successfully cast, pick 1 enemy unit within " +
                 "range and visible to the caster. That unit suffers D3 mortal wounds. Add 2\" to the range of this spell for each other friendly STORMCAST ETERNALS THUNDERSTRIKE unit wholly within 12\" of the caster.") } ),
                 new Entities.Hero("Celestan Prime", 12, 3, 10, 8, 1, 330, new List<string>(){"SINGLE", "UNIQUE","ORDER", "STORMCAST ETERNALS", "HERO", "CELESTANT-PRIME"}, new List<Attack>(){new Attack("Ghal Maraz",3,2,3,"3","3", 2, true)}, new List<Ability>(){new Ability("" +
                 "Cometstrike Sceptre: In your shooting phase, you can pick 1 point on the battlefield within 24\" of this unit and visible to it. Each enemy unit within 3\" of that point " +
                 "suffers D3 mortal wounds."), new Ability( "Retribution from On High: Instead of setting up this unit on the battlefield, you can place it to one side and say that it is set up in " +
                 "the heavens as a reserve unit. If you do so, at the end of your movement phase, you must say if this unit will remain in reserve or if it will strike from the " +
                 "heavens.\r\n\r\nAt the end of your movement phase, if this unit remains in reserve, add 2 to the Attacks characteristic of this unit’s Ghal Maraz for the rest of" +
                 " the battle. If this unit strikes from the heavens, set this unit up on the battlefield more than 9\" from all enemy units.\r\n"), new Ability( "Orrery of Celestial Fates: " +
                 "Once per turn, before you make a hit or wound roll for an attack made by this unit, a save roll for an attack that targets this unit, or a run or charge roll " +
                 "for this unit, you can say that you will foresee the result of the roll. If you do so, instead of making the roll, you must choose the result of the roll." +
                 " The result chosen for a D6 roll must be a whole number from 1 to 6, and the result chosen for a 2D6 roll must be a whole number from 2 to 12. The result " +
                 "cannot be re-rolled, but any modifiers are applied to it as normal."),new Ability( "Eye of the Celestial Storm: This unit has a ward of 4+.") })
             };

            _herolist.Heros = heroes.Cast<IHero>().ToList();
            DataManager.WriteHeroListJsonToPath(_herolist);


            _commandTraitList = new List<CommandTrait>()
            {
                new CommandTrait("Master of Magic", "nce per hero phase, you can re-roll one casting roll, dispelling roll or unbinding roll for this general."),
                new CommandTrait("Battle-lust", "You can re-roll run rolls and charge rolls for this general.")
            };
            DataManager.WriteCommandsListJsonToPath(_commandTraitList);
            _spellList = new List<Spell>()
            {
                new Spell("Arcane Bolt", "Arcane Bolt is a spell that has a casting value of 5 and a range of 12\". If successfully cast, at the start of any 1 phase before your next hero phase, you can pick 1 enemy unit within range and visible to the caster. That unit suffers 1 mortal wound. If that unit is within 3\" of the caster, it suffers D3 mortal wounds instead of 1."),
                new Spell("Mystic Shield", "Mystic Shield is a spell that has a casting value of 5 and a range of 12\". If successfully cast, pick 1 friendly unit wholly within range and visible to the caster. Add 1 to save rolls for attacks that target that unit until your next hero phase.")
            };
            DataManager.WriteSpellListJsonToPath(_spellList);
            _prayerList = new List<Prayer>()
            {
                new Prayer("Heal", "Answer value 3. Pick 1 friendly model within 12″ and visible to the chanter. You can heal up to D3 wounds allocated to that model."),
                new Prayer("Guidance","Answer value 5. Receive 1 command point."),
                new Prayer("Curse","Answer value 4. Pick 1 enemy unit within 9″ and visible to the chanter. Until your next hero phase, if the unmodified hit roll for an attack that targets that unit is 6, that unit suffers 1 mortal wound in addition to any normal damage")
            };
            DataManager.WritePrayerListJsonToPath(_prayerList);
            _artefactList = new List<Artefact>()
            {
                new Artefact("Amulet of Destiny","The bearer has a ward of 5+. "),
                new Artefact("Vial of Manticore Venom","Pick 1 of the bearer’s melee weapons. Add 1 to wound rolls for attacks made with that weapon."),
                new Artefact("Arcane Tome","The bearer becomes a Wizard that knows the Arcane Bolt and Mystic Shield spells. They can attempt to cast 1 spell in your hero phase and attempt to unbind 1 spell in the enemy hero phase. If the bearer is already a Wizard, they can attempt to cast 1 additional spell instead.")
            };
            DataManager.WriteArtefactListJsonToPath(_artefactList);
            var unitsLists = new List<Units>()
            {
                new Units("Vindictors", 5, 3,7,2, 5, 130, new List<string>(){"ORDER", "STORMCAST ETERNALS", "THUNDERSTRIKE", "REDEEMER", "VINDICTORS", "BATTLELINE"}, new List<Attack>(){new Attack("Stormspear", 3,3,1,"1","2",2,true)}, new List<Ability>(){new Ability("CHAMPION: 1 model in this unit can be a Vindictor-Prime. Add 1 to the Attacks characteristic of that model’s Stormspear."),new Ability( "STANDARD BEARER: 1 in every 5 models in this unit can be an Azyrite Signifier. Add 1 to the Bravery characteristic of a unit that includes any Azyrite Signifiers."), new Ability("Stormsoul Arsenal:If the unmodified hit roll for an attack made with a Stormspear is 6, the target suffers 1 mortal wound and the attack sequence ends (do not make a wound or save roll).")}),
                new Units("Sequitors",5,4,7,2, 5, 120, new List<string>(){"ORDER", "STORMCAST ETERNALS", "SACROSANCT", "REDEEMER", "SEQUITORS","BATTLELINE"}, new List<Attack>(){new Attack("Sacrosanct Weapons", 3,3,1,"1","2",1,true), new Attack("Stormsmite Greatmace", 3,3,1,"2","2",1, true)}, new List<Ability>(){new Ability("CHAMPION: 1 model in this unit can be a Sequitor-Prime. Add 1 to the Attacks characteristic of that model’s Sacrosanct Weapons or Stormsmite Greatmace. If a Sequitor-Prime is armed with Sacrosanct Weapons and a Soulshield, it can also carry a Redemption Cache."), new Ability( "Redemption Cache:Slain models cannot be returned to enemy units that are within 3\" of this unit’s Sequitor-Prime."), new Ability("Sequitor Aetheric Channelling: At the start of the combat phase, you must say whether this unit will channel aetheric power into its weapons or into its shields.\r\n\r\nIf you pick its weapons, until the end of that phase, if the unmodified hit roll for an attack made by this unit is 6, that attack scores 2 hits on the target instead of 1. Make a wound and save roll for each hit.\r\n\r\nIf you pick its shields, until the end of that phase, this unit has a ward of 5+.")}),
                new Units("Annihilators", 4, 2,7,3,3,180, new List<string>(){"ORDER", "STORMCAST ETERNALS", "THUNDERSTRIKE", "PALADIN", "ANNIHILATORS" }, new List<Attack>(){new Attack("Meteoric Hammer",3,3,1,"2", "3", 1, true)}, new List<Ability>(){new Ability("CHAMPION: 1 model in this unit can be an Annihilator-Prime. Add 1 to the Attacks characteristic of that model’s Meteoric Hammer."), new Ability( "Blazing Impact: After this unit is set up on the battlefield for the first time, roll a dice for each enemy unit within 10\" of this unit. On a 3+, that unit suffers D3 mortal wounds. In addition, you can re-roll charge rolls for this unit if it was set up on the battlefield in the same turn."), new Ability( "Force of a Falling Star: After this unit makes a charge move, you can pick 1 enemy unit within 1\" of this unit and roll a number of dice equal to the unmodified charge roll for that charge move. Subtract 1 from the roll if this unit only has 2 models. Subtract 2 from the roll if this unit only has 1 model. For each 4+, that enemy unit suffers 1 mortal wound.")}),
                new Units("Celestar Ballista", 3,4,7,9, 1, 130, new List<string>(){"ORDER", "STORMCAST ETERNALS", "SACROSANCT", "ORDINATORS", "WAR MACHINE", "CELESTAR BALLISTA", "ARTILLARY"}, new List<Attack>(){new Attack("Celestar Stormbolts: Lightning-charged Shot", 3,2,3,"D6", "1", 36, false), new Attack("Celestar Stormbolts: Rapid Fire", 3,3,1,"1","2D6", 18, false), new Attack("Sigmarite Blades", 3,3,1,"1","4" ,1,true)}, new List<Ability>(){new Ability("CREW: A Celestar Ballista has a crew of 2 Sacristan Engineers, who are armed with Sigmarite Blades. The crew must remain within 1\" of the Celestar Ballista. For rules purposes, the Celestar Ballista and its crew are treated as a single model."),new Ability( "Versatile Weapon: Each time this unit shoots, choose either the Lightning-charged Shot or Rapid Fire weapon characteristics for all the attacks it makes with its Celestar Stormbolts.")}),
                new Units("Gryph-hounds", 9,0,6,2, 6,90, new List<string>(){"ORDER", "STORMCAST ETERNALS", "GRYPH-HOUNDS"}, new List<Attack>(){new Attack("Vicious Beak and Claws", 3,4,0,"1","4",1,true)}, new List<Ability>(){new Ability("CHAMPION: If this unit has 3 or more models, 1 model in this unit can be a Gryph-hound Alpha. Add 1 to the Attacks characteristics of that model’s Vicious Beak and Claws."), new Ability( "Darting Attacks: After this unit has fought and all of its attacks have been resolved, it can retreat 6\"."),new Ability( "Warning Cry: If an enemy reserve unit or summoned unit is set up on the battlefield for the first time within 12\" of this unit, you can pick up to 3 friendly STORMCAST ETERNALS units wholly within 12\" of this unit to shoot. Any shooting attacks made by a STORMCAST ETERNALS unit picked with this ability must target that reserve unit or summoned unit.")})
            };
            DataManager.WriteUnitListJsonToPath(_units);
            _units.Unitss = new List<Units>() { };
            _units.Unitss.AddRange(unitsLists);

            _reactionsList = new List<Reactions>()
            {
                new Reactions("If a friendly STORMCAST ETERNALS model is slain within 1\" of an enemy unit, before removing that model from play, pick 1 enemy unit within 1\" of that model and roll a number of dice equal to the Wounds characteristic of that slain model. Add 1 to the number of dice you roll if the slain model has the THUNDERSTRIKE keyword. For each 6+, the target suffers 1 mortal wound at the end of that phase.", factionsList.FirstOrDefault(x => x.FactionName.Equals("Stormcast Eternals")) )
            };
            DataManager.WriteReactionsListJsonToPath(_reactionsList);

 
        }
    }
}
