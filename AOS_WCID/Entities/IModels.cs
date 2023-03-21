using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Entities
{
    public interface IModels
    {
        string Name();
        List<string> Keywords();
        List<string> Abilities();

    }
}
