using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AOS_WCID.Entities
{
    public interface IUnit:IModels
    {
        public string Name { get; set; }
        public int Move { get; set; }
        public int Save { get; set; }
        public int Bravery { get; set; }
        public int Wounds { get; set; }
        public int Size { get; set; }
        public int Points { get; set; }
        public List<string> Keywords { get; set; }
        public List<Attack> Attacks { get; set; }
     
    }
}
