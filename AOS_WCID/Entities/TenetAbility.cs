using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class TenetAbility
    {
        private string name;
        private string description;

        public TenetAbility(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
