using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOS_WCID;

namespace AOS_WCID
{
    public class Main
    {
        public void StartGame()
        {
            EingabeGameMode();

        }


        static void EingabeGameMode()
        {
            Console.WriteLine("Für welchen Spielmodus möchtest du erstellen");
            Console.WriteLine("1 für Path to Glory \n 2 für normal");

            ConsolenReader reader = new ConsolenReader();
            string consoleEingabe = "2";
            consoleEingabe = reader.GetLine();
            Console.WriteLine(consoleEingabe);
        }
    }
}
