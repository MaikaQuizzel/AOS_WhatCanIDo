using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Ability
    {
        private string description;

        public Ability(string description)
        {
            this.description = description;
        }

        public string Description { get => description; set => description = value; }
    }
}
