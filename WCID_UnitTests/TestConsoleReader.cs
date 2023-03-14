using AOS_WCID.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCID_UnitTests
{
    internal class TestConsoleReader : ConsolenReader
    {
        public override string GetLine()
        {
            return "Ich bin die Eingabe!";
        }
    }
}
