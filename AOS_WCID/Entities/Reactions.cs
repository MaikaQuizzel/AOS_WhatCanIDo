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
        private string _whenReaction;
        private string _whatReaction;
        private string _text;

        public Reactions(string name)
        {
            _name = name;
        }

        public Reactions(string name, string whenReaction, string whatReaction, string text)
        {
            _name = name;
            _whenReaction = whenReaction;
            _whatReaction = whatReaction;
            _text = text;
        }

        public string WhenReaction { get => _whenReaction; }
        public string WhatReaction { get => _whatReaction; }
        public string Text { get => _text; }
    }
}
