using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOS_WCID.Entities;

namespace AOS_WCID.Logic
{
    public class PlayerPicks
    {
        private string gameName = "";
        private GrandAlliance grandAlliance;
        private Faction faction;
        private Subfaction subfaction;
        private Batallion batallion;
        private List<Hero> _heroList;
        private List<IUnit> _unitsList;
        private List<TenetAbility> tenetAbilities;
        private List<Tenets> tenets;
        private CommandTrait _commandTrait;
        private List<Artefact> _artefactList;


        public PlayerPicks() 
        {
            tenetAbilities = new List<TenetAbility>();
            _heroList = new List<Hero>();
            Tenets = new List<Tenets>();
            _unitsList = new List<IUnit>();
            _artefactList = new List<Artefact>();
        }

        public string GameName { get => gameName; set => gameName = value; }
        public GrandAlliance GrandAlliance { get => grandAlliance; set => grandAlliance = value; }
        public Faction Faction { get => faction; set => faction = value; }
        public Subfaction Subfaction { get => subfaction; set => subfaction = value; }
        public Batallion Batallion { get => batallion; set => batallion = value; }
        public List<Hero> HeroList { get => _heroList; set => _heroList = value; }
        public List<TenetAbility> TenetAbilities { get => tenetAbilities; set => tenetAbilities = value; }
        public List<Tenets> Tenets { get => tenets; set => tenets = value; }
        public List<IUnit> UnitsList { get => _unitsList; set => _unitsList = value; }
        public CommandTrait CommandTrait { get => _commandTrait; set => _commandTrait = value; }
        public List<Artefact> ArtefactList { get => _artefactList; set => _artefactList = value; }
    }
}
