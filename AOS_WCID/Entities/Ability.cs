using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Ability
    {
        private string _description;

        public Ability(string description)
        {
            _description = description;
        }

        public string Description { get => _description; set => _description = value; }
    }
}
