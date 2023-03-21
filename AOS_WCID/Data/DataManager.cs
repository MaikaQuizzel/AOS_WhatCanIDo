using AOS_WCID.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AOS_WCID.Data
{
    public class DataManager
    {
        private static readonly string TENETSJSON = "Tenets.json";
        private static readonly string GAJASON = "GrandAlliance.json";
        private static readonly string FACTIONSJSON = "Factions.json";
        private static readonly string SUBFACTIONSJSON = "SubFactions.json";
        private static readonly string TENETABILITIES = "TenetsAbilities.json";



        public static void WriteTenetsJsonToPath(List<Tenets>entities) 
        {
            string path = TENETSJSON;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json); 
        }

        public static List<Tenets> ReadTenetsJsonToPath()
        {
            List<Tenets> entities = new List<Tenets>();

            using (StreamReader r = new StreamReader(TENETSJSON))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<Tenets>>(json);
            }

            return entities;
        }

        public static void WriteGrandAllianceJsonToPath(List<GrandAlliance> entities)
        {
            string path = GAJASON;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }

        public static List<GrandAlliance> ReadGrandAllianceJsonToPath()
        {
            List<GrandAlliance> entities = new List<GrandAlliance>();

            using(StreamReader r = new StreamReader(GAJASON))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<GrandAlliance>>(json);
            }
            return entities;
        }

        public static void WriteFactionsJsonToPath(List<Faction> entities)
        {
            string path = FACTIONSJSON;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }
        public static List<Faction> ReadFactionsJsonToPath()
        {
            List<Faction> entities = new List<Faction>();

            using (StreamReader r = new StreamReader(FACTIONSJSON))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<Faction>>(json);
            }
            return entities;
        }

        public static void WriteSubfactionListJsonToPath(List<Subfaction> entities)
        {
            string path = SUBFACTIONSJSON;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }
        public static List<Subfaction> ReadSubfactionListJsonToPath()
        {
            List<Subfaction> entities = new List<Subfaction>();

            using (StreamReader r = new StreamReader(SUBFACTIONSJSON))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<Subfaction>>(json);
            }
            return entities;
        }
        public static void WriteTenetAbilitiesListJsonToPath(List<TenetAbility> entities)
        {
            string path = TENETABILITIES;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }
        public static List<TenetAbility> ReadTenetAbilitiesListJsonToPath()
        {
            List<TenetAbility> entities = new List<TenetAbility>();

            using (StreamReader r = new StreamReader(TENETABILITIES))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<TenetAbility>>(json);
            }
            return entities;
        }

    }
}
