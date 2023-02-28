namespace AOS_WCID
{
    public class Faction
    {
        private string factionName;  
        private GrandAlliance grandAlliance { get; set; }

        public Faction(string factionName, GrandAlliance grandAlliance)
        {
            this.factionName = factionName;
            this.grandAlliance = grandAlliance;
        }
        public string FactionName { get=> factionName; set=> factionName = value; }
        public GrandAlliance GrandAlliance { get => grandAlliance; set => grandAlliance = value; }
    }
}