using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public interface IModels
    {
        public string Name { get; set; }
        public List<string> Keywords { get; set; }
        public List<Ability> Abilities { get; set; }
    }
}
