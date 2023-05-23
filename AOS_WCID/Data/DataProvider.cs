using AOS_WCID.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Data
{
    public class DataProvider
    {
        private DataToWriteCollection _dataToWriteCollection;
        //private readonly Hero hero = DataManager.ReadListJsonToPath();
        private readonly List<GrandAlliance> alliancesList = DataManager.ReadGrandAllianceJsonToPath();
        private readonly List<Subfaction> subfactionList = DataManager.ReadSubfactionListJsonToPath();
        private readonly List<Tenets> tenetList = DataManager.ReadTenetsJsonToPath();
        private readonly List<TenetAbility> tenetAbilityListHammer = DataManager.ReadHammerAbilitiesListJsonToPath();
        private readonly List<TenetAbility> tenetAbilityListShield = DataManager.ReadShieldAbilitiesListJsonToPath();
        private readonly List<TenetAbility> tenetAbilityListTempest = DataManager.ReadTempestAbilitiesListJsonToPath();
        private readonly List<Batallion> batallionList = DataManager.ReadBatallionListJsonToPath();
        private readonly HeroesList heroList = new HeroesList();
        //private readonly HeroesList heroList = DataManager.ReadHeroListJsonToPath(); //Herrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr geht nicht
        private readonly List<CommandTrait> _commandTraitList = DataManager.ReadCommandsListJsonToPath();
        private readonly List<Faction> factionsList = DataManager.ReadFactionsJsonToPath();
        private readonly List<Artefact> _artefactList = DataManager.ReadArtefactListJsonToPath();
        private readonly List<Spell> _spellList = DataManager.ReadSpellListJsonToPath();
        private readonly List<Prayer> _prayerList = DataManager.ReadPrayerListJsonToPath();
        private readonly UnitList _unitsList = new UnitList();
        private readonly List<Reactions> _reactionList = DataManager.ReadReactionsListJsonToPath();
        private readonly EndlessSpellList endlessSpellsList = new EndlessSpellList();
       
       


        public DataProvider(DataToWriteCollection dataToWriteCollection) { 
   
            heroList = dataToWriteCollection.Herolist;
            endlessSpellsList = dataToWriteCollection.EndlessSpellList;
            //_unitsList = dataToWriteCollection.
        
        }

        public List<GrandAlliance> AlliancesList { get => alliancesList;  }
        public List<Faction> FactionsList { get => factionsList;  }
        public List<Subfaction> SubfactionList { get => subfactionList;  }
        public List<Tenets> TenetList { get => tenetList; }
        public List<TenetAbility> TenetAbilityListHammer { get => tenetAbilityListHammer;  }
        public List<TenetAbility> TenetAbilityListShield { get => tenetAbilityListShield;  }
        public List<TenetAbility> TenetAbilityListTempest { get => tenetAbilityListTempest;  }
        public List<Batallion> BatallionList { get => batallionList;  }
        public HeroesList HeroList { get => heroList;  }
        public List<CommandTrait> CommandTraitList { get => _commandTraitList;  }
        public List<Artefact> ArtefactList { get => _artefactList; }
        public List<Spell> SpellList { get => _spellList; }
        public List<Prayer> PrayerList { get => _prayerList;  }
        public UnitList UnitsList { get => _unitsList;  }
        public List<Reactions> ReactionList { get => _reactionList; }
        public EndlessSpellList EndlessSpellsList { get => endlessSpellsList; }

        
    }
}
