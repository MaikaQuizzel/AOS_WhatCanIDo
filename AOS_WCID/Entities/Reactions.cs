using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Reactions
    {
        private string _name;
        private Faction _faction;

        public Reactions(string name, Faction faction)
        {
            _name = name;
            _faction = faction;
        }

        public string Name { get => _name; set => _name = value; }
        public Faction Faction { get => _faction; set => _faction = value; }
    }
}
