﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Spell
    {
        private string _name;
        private string _description;
        private Hero _owner;

        public Spell(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public Hero Owner { get => _owner; set => _owner = value; }
    }
}
