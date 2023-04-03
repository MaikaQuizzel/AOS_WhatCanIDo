﻿using AOS_WCID.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Data
{
    public class DataProvider
    {
        private List<GrandAlliance> alliancesList;
        private List<Faction> factionsList;
        private List<Subfaction> subfactionList;
        private List<Tenets> tenetList;
        private List<TenetAbility> tenetAbilityListHammer;
        private List<TenetAbility> tenetAbilityListShield;
        private List<TenetAbility> tenetAbilityListTempest;
        private List<Batallion> batallionList;
        private List<Hero> heroList;
        private List<CommandTrait> _commandTraitList;
        private List<Artefact> _artefactList;
        private List<Spell> _spellList;
        private List<Prayer> _prayerList;
        private List<Units> _unitsList;
        private List<Reactions> _reactionList;
        private List<EndlessSpell> endlessSpellsList;


        public DataProvider() { }

        public List<GrandAlliance> AlliancesList { get => alliancesList; set => alliancesList = value; }
        public List<Faction> FactionsList { get => factionsList; set => factionsList = value; }
        public List<Subfaction> SubfactionList { get => subfactionList; set => subfactionList = value; }
        public List<Tenets> TenetList { get => tenetList; set => tenetList = value; }
        public List<TenetAbility> TenetAbilityListHammer { get => tenetAbilityListHammer; set => tenetAbilityListHammer = value; }
        public List<TenetAbility> TenetAbilityListShield { get => tenetAbilityListShield; set => tenetAbilityListShield = value; }
        public List<TenetAbility> TenetAbilityListTempest { get => tenetAbilityListTempest; set => tenetAbilityListTempest = value; }
        public List<Batallion> BatallionList { get => batallionList; set => batallionList = value; }
        public List<Hero> HeroList { get => heroList; set => heroList = value; }
        public List<CommandTrait> CommandTraitList { get => _commandTraitList; set => _commandTraitList = value; }
        public List<Artefact> ArtefactList { get => _artefactList; set => _artefactList = value; }
        public List<Spell> SpellList { get => _spellList; set => _spellList = value; }
        public List<Prayer> PrayerList { get => _prayerList; set => _prayerList = value; }
        public List<Units> UnitsList { get => _unitsList; set => _unitsList = value; }
        public List<Reactions> ReactionList { get => _reactionList; set => _reactionList = value; }
        public List<EndlessSpell> EndlessSpellsList { get => endlessSpellsList; set => endlessSpellsList = value; }

        public void InitializeStuff()
        {
            //Dummy Data from JSON
            alliancesList = DataManager.ReadGrandAllianceJsonToPath();

            FactionsList = DataManager.ReadFactionsJsonToPath();

            SubfactionList =DataManager.ReadSubfactionListJsonToPath();

            TenetAbilityListHammer = DataManager.ReadHammerAbilitiesListJsonToPath();

            TenetAbilityListShield = DataManager.ReadShieldAbilitiesListJsonToPath();

            TenetAbilityListTempest = DataManager.ReadTempestAbilitiesListJsonToPath();

            TenetList = DataManager.ReadTenetsJsonToPath();

            BatallionList = DataManager.ReadBatallionListJsonToPath();

            HeroList = DataManager.ReadHeroListJsonToPath();  
            
            CommandTraitList = DataManager.ReadCommandsListJsonToPath();

            ArtefactList = DataManager.ReadArtefactListJsonToPath();   
            
            SpellList = DataManager.ReadSpellListJsonToPath();  

            PrayerList = DataManager.ReadPrayerListJsonToPath();
            
            UnitsList = DataManager.ReadUnitListJsonToPath();

            ReactionList = DataManager.ReadReactionsListJsonToPath();

            EndlessSpellsList = DataManager.ReadEndlessSpellsListJsonToPath();
        }
    }
}
