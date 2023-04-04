using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Units : IUnit
    {
        string _name;
        int _move;
        int _save;
        int _bravery;
        int _wounds;
        int _size;
        int _points;
        List<string> _keywords;
        List<Attack> _attacks;
        List<string> _abilities;

        public Units(string name, int move, int save, int bravery, int wounds, int size, int points, List<string> keywords, List<Attack> attacks, List<string> abilities)
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

        public List<string> Abilities()
        {
            return _abilities;
        }

        public List<Attack> Attacks()
        {
            return _attacks;
        }

        public int Bravery()
        {
            return _bravery;
        }

        public List<string> Keywords()
        {
            return _keywords;
        }

        public int Move()
        {
            return _move;
        }

        public string Name()
        {
            return _name;
        }

        public int Points()
        {
            return _points;
        }

        public int Save()
        {
            return _save;
        }

        public int Size()
        {
            return _size;
        }

        public int Wounds()
        {
            return _wounds;
        }
    }       
}
