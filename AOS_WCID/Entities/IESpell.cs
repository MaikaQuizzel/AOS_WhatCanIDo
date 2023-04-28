using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public interface IESpell : IModels
    {
        public int Points { get; set; }
        public string Summoning { get; set; }
        public string Predatory { get; set; }
        public string Description { get; set; }
    }
}
