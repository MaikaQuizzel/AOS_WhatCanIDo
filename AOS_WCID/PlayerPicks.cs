using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID
{
    public class PlayerPicks
    {
        private string gameName = "";
        private GrandAlliance grandAlliance;
        private Faction faction;
        private Subfaction subfaction;
        private Batallion batallion;
        private List<Unit> armyList;


        public PlayerPicks() { }

        public string GameName { get => gameName; set => gameName = value; }
        public GrandAlliance GrandAlliance { get => grandAlliance; set => grandAlliance = value; }
        public Faction Faction { get => faction; set => faction = value; }
        public Subfaction Subfaction { get => subfaction; set => subfaction = value; }
        public Batallion Batallion { get => batallion; set => batallion = value; }
        public List<Unit> ArmyList { get => armyList; set => armyList = value; }
    }
}
