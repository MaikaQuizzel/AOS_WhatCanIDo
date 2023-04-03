using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class CommandTrait
    {
        string name;
        string description;
        private Hero _owner;

        public CommandTrait(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public string Name { get => name;  }
        public string Description { get => description;  }
        public Hero Owner { get => _owner; set => _owner = value; }
    }
}
