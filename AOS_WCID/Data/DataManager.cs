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
        private static readonly string ORDERJSON = "Order.json";

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

        public static void WriteOrderJsonToPath()
    }
}
