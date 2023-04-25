using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class EndlessSpellList
    {
        private List<EndlessSpell> _endlessSpellList = new List<EndlessSpell>();


        public EndlessSpellList(List<EndlessSpell> spells) 
        { 
            _endlessSpellList = spells;
        }


        public List<EndlessSpell> EndlessSpellLISTE { get => _endlessSpellList; set => _endlessSpellList = value; }   
    }
}
