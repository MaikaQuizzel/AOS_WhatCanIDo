﻿using AOS_WCID.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
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
        private static readonly string HEROS = "Heros.json";
        private static readonly string COMMANDTRAITS = "CommandTraits.json";
        private static readonly string ARTAFACTS = "Artefacrts.json";
        private static readonly string SPELLS = "Spells.json";
        private static readonly string PRAYER = "Prayer.json";
        private static readonly string UNITS = "Units.json";
        private static readonly string REACTIONS = "Reactions.json";



        public static void WriteTenetsJsonToPath(List<Tenets>entities) 
        {
            string path = TENETSJSON;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

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

            if (entities == null || !entities.Any())
            {
                throw new DataException(TENETSJSON);
            }


            return entities;
        }

        public static void WriteGrandAllianceJsonToPath(List<GrandAlliance> entities)
        {
            string path = GAJASON;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

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

            if (entities == null || !entities.Any())
            {
                throw new DataException(GAJASON);
            }

            return entities;
        }

        public static void WriteFactionsJsonToPath(List<Faction> entities)
        {
            string path = FACTIONSJSON;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

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

            if (entities == null || !entities.Any())
            {
                throw new DataException(FACTIONSJSON);
            }

            return entities;
        }

        public static void WriteSubfactionListJsonToPath(List<Subfaction> entities)
        {
            string path = SUBFACTIONSJSON;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

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

            if (entities == null || !entities.Any())
            {
                throw new DataException(SUBFACTIONSJSON);
            }

            return entities;
        }
        public static void WriteHammerAbilitiesListJsonToPath(List<TenetAbility> entities)
        {
            string path = HAMMERABILITIES;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

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

            if (entities == null || !entities.Any())
            {
                throw new DataException(HAMMERABILITIES);
            }

            return entities;
        }
        public static void WriteShiedAbilitiesListJsonToPath(List<TenetAbility> entities)
        {
            string path = SHIELSABILITIES;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

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

            if (entities == null || !entities.Any())
            {
                throw new DataException(SHIELSABILITIES);
            }

            return entities;
        }
        public static void WriteTempestAbilitiesListJsonToPath(List<TenetAbility> entities)
        {
            string path = TEMPESTABILITIES;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

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


            if (entities == null || !entities.Any())
            {
                throw new DataException(TEMPESTABILITIES);
            }

            return entities;
        }

        public static void WriteBatallionListJsonToPath(List<Batallion> entities)
        {
            string path = BATALLION;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

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

            if (entities == null || !entities.Any())
            {
                throw new DataException(BATALLION);
            }

            return entities;
        }
        public static void WriteEndlessSpellsListJsonToPath(EndlessSpellList entities)
        {
            string path = ENDLESSSPELLS;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

            File.WriteAllText(path, json);
        }
        public static EndlessSpellList ReadEndlessSpellsListJsonToPath()
        {
            EndlessSpellList entities ;

            using (StreamReader r = new StreamReader(ENDLESSSPELLS))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<EndlessSpellList>(json);
            }

            if (entities == null || !entities._endlessSpellList.Any())
            {
                throw new DataException(ENDLESSSPELLS);
            }

            return entities;
        }

        public static void WriteHeroListJsonToPath(HeroesList entities)
        {
            string path = HEROS;
            string json = JsonSerializer.Serialize(entities);   // DAs tut nicht serialisieren but why

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

            File.WriteAllText(path, json);
        }
        public static HeroesList ReadHeroListJsonToPath()
        {
            HeroesList entities = new HeroesList();

            using (StreamReader r = new StreamReader(HEROS))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<HeroesList>(json);
            }

            if (entities == null || !entities.Heros.Any())
            {
                throw new DataException(HEROS);
            }

            return entities;
        }

        public static void WriteCommandsListJsonToPath(List<CommandTrait> entities)
        {
            string path = COMMANDTRAITS;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

            File.WriteAllText(path, json);
        }
        public static List<CommandTrait> ReadCommandsListJsonToPath()
        {
            List<CommandTrait> entities = new List<CommandTrait>();

            using (StreamReader r = new StreamReader(COMMANDTRAITS))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<CommandTrait>>(json);
            }

            if (entities == null || !entities.Any())
            {
                throw new DataException(COMMANDTRAITS);
            }

            return entities;
        }
        public static void WriteArtefactListJsonToPath(List<Artefact> entities)
        {
            string path = ARTAFACTS;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

            File.WriteAllText(path, json);
        }
        public static List<Artefact> ReadArtefactListJsonToPath()
        {
            List<Artefact> entities = new List<Artefact>();

            using (StreamReader r = new StreamReader(ARTAFACTS))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<Artefact>>(json);
            }

            if (entities == null || !entities.Any())
            {
                throw new DataException(ARTAFACTS);
            }

            return entities;
        }
        public static void WriteSpellListJsonToPath(List<Spell> entities)
        {
            string path = SPELLS;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

            File.WriteAllText(path, json);
        }
        public static List<Spell> ReadSpellListJsonToPath()
        {
            List<Spell> entities = new List<Spell>();

            using (StreamReader r = new StreamReader(SPELLS))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<Spell>>(json);
            }

            if (entities == null || !entities.Any())
            {
                throw new DataException(SPELLS);
            }

            return entities;
        }
        public static void WritePrayerListJsonToPath(List<Prayer> entities)
        {
            string path = PRAYER;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

            File.WriteAllText(path, json);
        }
        public static List<Prayer> ReadPrayerListJsonToPath()
        {
            List<Prayer> entities = new List<Prayer>();

            using (StreamReader r = new StreamReader(PRAYER))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<Prayer>>(json);
            }

            if (entities == null || !entities.Any())
            {
                throw new DataException(PRAYER);
            }

            return entities;
        }
        public static void WriteUnitListJsonToPath(UnitList entities)
        {
            string path = UNITS;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

            File.WriteAllText(path, json);
        }

        public static void WriteReactionsListJsonToPath(List<Reactions> entities)
        {
            string path = REACTIONS;
            string json = JsonSerializer.Serialize(entities);

            if (json == "null" || json == "[]")
            {
                throw new DataException(path);
            }

            File.WriteAllText(path, json);
        }
        public static List<Reactions> ReadReactionsListJsonToPath()
        {
            List<Reactions> entities = new List<Reactions>();

            using (StreamReader r = new StreamReader(REACTIONS))
            {
                string json = r.ReadToEnd();
                entities = JsonSerializer.Deserialize<List<Reactions>>(json);
            }

            if (entities == null || !entities.Any())
            {
                throw new DataException(REACTIONS);
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
        public static void WriteJsonToPath<T>(List<T> entities, string path)
        {
            var json = JsonSerializer.Serialize(entities);
            File.WriteAllText(path, json);
        }

        public static List<T> ReadJsonFromPath<T>(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                return JsonSerializer.Deserialize<List<T>>(json);
            }
        }

    }
}
