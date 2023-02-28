using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID
{
    public class GrandAlliance
    {
        private string name;
        public GrandAlliance(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
