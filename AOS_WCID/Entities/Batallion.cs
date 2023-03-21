using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public class Batallion
    {
        private string name;
        private string description;
        private int commanderCount;
        private int subcommanderCount;
        private int troopCount;
        private int monseterCount;
        private int artilleryCount;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int CommanderCount { get => commanderCount; set => commanderCount = value; }
        public int SubcommanderCount { get => subcommanderCount; set => subcommanderCount = value; }
        public int TroopCount { get => troopCount; set => troopCount = value; }
        public int MonseterCount { get => monseterCount; set => monseterCount = value; }
        public int ArtilleryCount { get => artilleryCount; set => artilleryCount = value; }

        public Batallion(string name, string description, int commanderCount, int subcommanderCount, int troopCount, int monseterCount, int artilleryCount)
        {
            this.Name = name;
            this.Description = description;
            this.CommanderCount = commanderCount;
            this.SubcommanderCount = subcommanderCount;
            this.TroopCount = troopCount;
            this.MonseterCount = monseterCount;
            this.ArtilleryCount = artilleryCount;
        }
    }
}
