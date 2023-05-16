using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOS_WCID.Entities;
using AOS_WCID.Entities.Interfaces;

namespace AOS_WCID
{
    public class Unit : IUnit
    {
        private int _size;
        private string _name;
        private int _movementRange;
        private List<Attack> _attackList = new List<Attack>();
        private int _save;
        private int _bravery;
        private int _wounds;
        private int _points;
        private List<string> _keywords = new List<string>();
        private int _renown;
        private bool _isGeneral = false;
        private List<Ability> _abilities = new List<Ability>();

        public Unit() { }
      

        public int Size { get => _size; set => _size = value; }
        public string Name { get => _name; set => _name = value; }
        public int Save { get => _save; set => _save = value; }
        public int Bravery { get => _bravery; set => _bravery = value; }
        public int Wounds { get => _wounds; set => _wounds = value; }
        public int Points { get => _points; set => _points = value; }
        public List<string> Keywords { get => _keywords; set => _keywords = value; }
        public int Renown { get => _renown; set => _renown = value; }
        public bool IsGeneral { get => _isGeneral; set => _isGeneral = value; }
        public int Move { get => _movementRange; set => _movementRange = value; }
        public List<Attack> Attacks { get => _attackList; set => _attackList = value; }
        public List<Ability> Abilities { get => _abilities; set => _abilities = value; }
      
    }
}
