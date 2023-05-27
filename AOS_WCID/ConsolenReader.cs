using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole
{
    public class ConsolenReader
    {
        public virtual string GetLine()
        {
            string eingabe = Console.ReadLine();

            if (!string.IsNullOrEmpty(eingabe))
                return eingabe;

            return "";
        }
    }

}
