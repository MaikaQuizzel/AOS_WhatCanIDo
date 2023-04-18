using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class EndlessSpell: IModels
    {
        private string _name;
        private int _points;
        private string _summoning;
        private string _predatory;
        private List<string> _abilityList;
        private string _description;
        private List<string> _keyWords;

        public EndlessSpell(string name, int points, string summoning, string predatory, List<string> abilityList, string description, List<string> keyWords)
        {
            _name = name;
            _points = points;
            _summoning = summoning;
            _predatory = predatory;
            _abilityList = abilityList;
            _description = description;
            _keyWords = keyWords;
        }

        
        public int Points { get => _points; }
        public string Summoning { get => _summoning;  }
        public string Predatory { get => _predatory; }
        public string Description { get => _description; }

        public string Name()
        {
            return _name;
        }

        public List<string> Keywords()
        {
            return _keyWords;
        }

        public List<string> Abilities()
        {
            return _abilityList;
        }
    }
}
