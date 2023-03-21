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
        private static readonly string HAMMERABILITIES = "HammerAbilities.json";
        private static readonly string SHIELSABILITIES = "ShieldAbilities.json";
        private static readonly string TEMPESTABILITIES = "TempestAbilities.json";
        private static readonly string BATALLION = "Batallion.json";
        private static readonly string ENDLESSSPELLS = "EndlessSpells.json";



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
        public static void WriteHammerAbilitiesListJsonToPath(List<TenetAbility> entities)
        {
            string path = HAMMERABILITIES;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }
        public static List<TenetAbility> ReadHammerAbilitiesListJsonToPath()
        {
            List<TenetAbility> entities = new List<TenetAbility>();

            using (StreamReader r = new StreamReader(HAMMERABILITIES))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<TenetAbility>>(json);
            }
            return entities;
        }
        public static void WriteShiedAbilitiesListJsonToPath(List<TenetAbility> entities)
        {
            string path = SHIELSABILITIES;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }
        public static List<TenetAbility> ReadShieldAbilitiesListJsonToPath()
        {
            List<TenetAbility> entities = new List<TenetAbility>();

            using (StreamReader r = new StreamReader(SHIELSABILITIES))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<TenetAbility>>(json);
            }
            return entities;
        }
        public static void WriteTempestAbilitiesListJsonToPath(List<TenetAbility> entities)
        {
            string path = TEMPESTABILITIES;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }
        public static List<TenetAbility> ReadTempestAbilitiesListJsonToPath()
        {
            List<TenetAbility> entities = new List<TenetAbility>();

            using (StreamReader r = new StreamReader(TEMPESTABILITIES))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<TenetAbility>>(json);
            }
            return entities;
        }

        public static void WriteBatallionListJsonToPath(List<Batallion> entities)
        {
            string path = BATALLION;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }
        public static List<Batallion> ReadBatallionListJsonToPath()
        {
            List<Batallion> entities = new List<Batallion>();

            using (StreamReader r = new StreamReader(BATALLION))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<Batallion>>(json);
            }
            return entities;
        }
        public static void WriteEndlessSpellsListJsonToPath(List<EndlessSpell> entities)
        {
            string path = ENDLESSSPELLS;
            string json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }
        public static List<EndlessSpell> ReadEndlessSpellsListJsonToPath()
        {
            List<EndlessSpell> entities = new List<EndlessSpell>();

            using (StreamReader r = new StreamReader(ENDLESSSPELLS))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<EndlessSpell>>(json);
            }
            return entities;
        }



        //public static void WriteListJsonToPath(List<> entities)
        //{
        //    string path = ;
        //    string json = JsonSerializer.Serialize(entities);
        //    File.WriteAllText(path, json);
        //}
        //public static List<> ReadListJsonToPath()
        //{
        //    List<> entities = new List<>();

        //    using (StreamReader r = new StreamReader())
        //    {
        //        string json = r.ReadToEnd();
        //        entities = JsonSerializer.Deserialize<List<>>(json);
        //    }
        //    return entities;
        //}

    }
}
