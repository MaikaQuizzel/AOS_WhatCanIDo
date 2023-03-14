namespace AOS_WCID.Entities
{
    public class Subfaction
    {
        private string name;
        private string description;
        private Faction faction;

        public Subfaction(string name, string description, Faction faction)
        {
            this.name = name;
            this.description = description;
            this.faction = faction;
        }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Faction Faction { get => faction; set => faction = value; }
    }
}