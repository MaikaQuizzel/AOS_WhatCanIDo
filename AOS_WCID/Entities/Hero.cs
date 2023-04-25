using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Hero : IUnit
    {

        private string _name;
        private int _move;
        private int _save;
        private int _bravery;
        private int _wounds;
        private int _size;
        private int _points;
        private List<string> _keywords;
        private List<Attack> _attacks;
        private List<Ability> _abilities;

        public Hero(string name, int move, int save, int bravery, int wounds, int size, int points, List<string> keywords, List<Attack> attacks, List<Ability> abilities)
        {
            _name = name;
            _move = move;
            _save = save;
            _bravery = bravery;
            _wounds = wounds;
            _size = size;
            _points = points;
            _keywords = keywords;
            _attacks = attacks;
            _abilities = abilities;
        }

        public string Name { get => _name; set => _name = value; }
        public int Move { get => _move; set => _move = value; }
        public int Save { get => _save; set => _save = value; }
        public int Bravery { get => _bravery; set => _bravery = value; }
        public int Wounds { get => _wounds; set => _wounds = value; }
        public int Size { get => _size; set => _size = value; }
        public int Points { get => _points; set => _points = value; }
        public List<string> Keywords { get => _keywords; set => _keywords = value; }
        public List<Ability> Abilities { get => _abilities; set => _abilities = value; }
        public List<Attack> Attacks { get => _attacks; set => _attacks = value; }

        //public List<string> Abilities()
        //{
        //    return _abilities;
        //}

        //public List<Attack> Attacks()
        //{
        //    return _attacks;
        //}

        //public int Bravery()
        //{
        //    return _bravery;
        //}

        //public List<string> Keywords()
        //{
        //    return _keywords;
        //}

        //public int Move()
        //{
        //    return _move;
        //}

        //public string Name()
        //{
        //    return _name;
        //}

        //public int Points()
        //{
        //    return _points;
        //}

        //public int Save()
        //{
        //    return _save;
        //}

        //public int Size()
        //{
        //    return _size;
        //}

        //public int Wounds()
        //{
        //    return _wounds;
        //}
    }
}
