using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup.Core
{
    public interface ICoreSelection
    {
        public void GenerateConsoleText();
        public void ReadValidInput();
    }
}
