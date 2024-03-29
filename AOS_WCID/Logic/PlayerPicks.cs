﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOS_WCID.Entities;
using AOS_WCID.Entities.Interfaces;

namespace AOS_WCID.Logic
{
    public sealed class PlayerPicks
    {
        private static readonly Lazy<PlayerPicks> lazy= new Lazy<PlayerPicks> ((() => new PlayerPicks()));
        public static PlayerPicks Instance { get { return lazy.Value; } }

        private string gameName = "";
        private GrandAlliance grandAlliance;
        private Faction faction;
        private Subfaction subfaction;
        private Batallion batallion;
        private List<IUnit> _heroList;
        private List<Units> _unitsList;
        private List<TenetAbility> tenetAbilities;
        private List<Tenets> tenets;
        private CommandTrait _commandTrait;
        private List<Artefact> _artefactList;
        private List<Spell> _spellList;
        private List<Prayer> _prayerList;
        private List<IModels> _endlessSpellList;


        private PlayerPicks() 
        {
            tenetAbilities = new List<TenetAbility>();
            _heroList = new List<IUnit>();
            Tenets = new List<Tenets>();
            _unitsList = new List<Units>();
            _artefactList = new List<Artefact>();
            _spellList = new List<Spell>();
            _prayerList = new List<Prayer>();
            _endlessSpellList = new List<IModels>();
        }

        public string GameName { get => gameName; set => gameName = value; }
        public GrandAlliance GrandAlliance { get => grandAlliance; set => grandAlliance = value; }
        public Faction Faction { get => faction; set => faction = value; }
        public Subfaction Subfaction { get => subfaction; set => subfaction = value; }
        public Batallion Batallion { get => batallion; set => batallion = value; }
        public List<IUnit> HeroList { get => _heroList; set => _heroList = value; }
        public List<TenetAbility> TenetAbilities { get => tenetAbilities; set => tenetAbilities = value; }
        public List<Tenets> Tenets { get => tenets; set => tenets = value; }
        public List<Units> UnitsList { get => _unitsList; set => _unitsList = value; }
        public CommandTrait CommandTrait { get => _commandTrait; set => _commandTrait = value; }
        public List<Artefact> ArtefactList { get => _artefactList; set => _artefactList = value; }
        public List<Spell> SpellList { get => _spellList; set => _spellList = value; }
        public List<Prayer> PrayerList { get => _prayerList; set => _prayerList = value; }
        public List<IModels> EndlessSpellList { get => _endlessSpellList; set => _endlessSpellList = value; }
    }
}
