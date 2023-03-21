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
        private List<GrandAlliance> alliancesList;
        private List<Faction> factionsList;
        private List<Subfaction> subfactionList;
        private List<Tenets> tenetList;
        private List<TenetAbility> tenetAbilityListHammer;
        private List<TenetAbility> tenetAbilityListShield;
        private List<TenetAbility> tenetAbilityListTempest;
        private List<Batallion> batallionList;


        public DataProvider() { }

        public List<GrandAlliance> AlliancesList { get => alliancesList; set => alliancesList = value; }
        public List<Faction> FactionsList { get => factionsList; set => factionsList = value; }
        public List<Subfaction> SubfactionList { get => subfactionList; set => subfactionList = value; }
        public List<Tenets> TenetList { get => tenetList; set => tenetList = value; }
        public List<TenetAbility> TenetAbilityListHammer { get => tenetAbilityListHammer; set => tenetAbilityListHammer = value; }
        public List<TenetAbility> TenetAbilityListShield { get => tenetAbilityListShield; set => tenetAbilityListShield = value; }
        public List<TenetAbility> TenetAbilityListTempest { get => tenetAbilityListTempest; set => tenetAbilityListTempest = value; }
        public List<Batallion> BatallionList { get => batallionList; set => batallionList = value; }

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
        }
    }
}
