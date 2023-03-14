using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Batallion
    {
        public string name { get; set; }
        public string description { get; set; }
        public int commanderCount { get; set; }
        public int subcommanderCount { get; set; }
        public int troopCount { get; set; }
        public int monseterCount { get; set; }
        public int artilleryCount { get; set; }
    }
}
