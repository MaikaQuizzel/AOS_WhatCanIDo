using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class EndlessSpell: IESpell
    {
        private string _name;
        private int _points;
        private string _summoning;
        private string _predatory;
        private List<Ability> _abilityList;
        private string _description;
        private List<string> _keyWords;

        public EndlessSpell(string name, int points, string summoning, string predatory, List<Ability> abilityList, string description, List<string> keyWords)
        {
            _name = name;
            _points = points;
            _summoning = summoning;
            _predatory = predatory;
            _abilityList = abilityList;
            _description = description;
            _keyWords = keyWords;
        }

        public string Name { get => _name; set => _name = value; }
        public List<string> Keywords { get => _keyWords; set => _keyWords = value; }
        public List<Ability> Abilities { get => _abilityList; set => _abilityList = value; }

        public int Points { get => _points; set => _points = value; }
        public string Summoning { get => _summoning; set => _summoning = value; }
        public string Predatory { get => _predatory; set => _predatory = value; }
        public string Description { get => _description; set => _description = value; }
        
        
    }
}
