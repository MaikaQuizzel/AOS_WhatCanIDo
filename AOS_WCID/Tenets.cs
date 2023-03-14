using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID
{
    public class Tenets
    {
        private string _name;
        private List<TenetAbility> _abilities;

        public Tenets(string name, List<TenetAbility> abilities)
        {
            _name = name;
            Abilities = abilities;
        }

        public List<TenetAbility> Abilities { get => _abilities; internal set => _abilities = value; }
        public string Name { get => _name; internal set => _name = value; }
    }
}
