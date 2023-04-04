using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole
{
    public class ConsoleSpacer
    {
        public ConsoleSpacer() { }

        public static void PrintSpacer()
        {
            StringBuilder chooseText = new StringBuilder();
            chooseText.AppendLine("");

            int size = 15;
            for (int i = 0; i < size; i++)
            {
                chooseText.Append("-");
            }
            chooseText.AppendLine("");
        }
    }
}
