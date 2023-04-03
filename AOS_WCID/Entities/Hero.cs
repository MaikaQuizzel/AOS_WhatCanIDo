using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Hero 
    {
        //public string Name1;
        //public int Move1;
        //public int Saver1;
        //public int Bravery1;
        //public int Wounds1;
        //public int Size1;
        //public int Points1;
        //public List<string> Keywords1;
        //public List<Attack> Attacks1;
        //public List<string> Abilities1;

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

        public Hero(string name, int move, int save, int bravery, int wounds, int size, int points, List<string> keywords, List<Attack> attacks, List<string> abilities)
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
        public List<Attack> Attacks { get => _attacks; set => _attacks = value; }
        public List<string> Abilities { get => _abilities; set => _abilities = value; }
    }
}
