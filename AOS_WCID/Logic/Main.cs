using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using AOS_WCID.Data;
using AOS_WCID.Konsole;
using AOS_WCID.Entities;
using AOS_WCID.Konsole.Setup;

namespace AOS_WCID.Logic
{
    public class Main
    {
        private DataProvider initialStuff;


        public void StartGame()
        {
            //DELETE ME IF ALL DATA IS WRITTEN !!!!!!1111elf
            DataToWriteCollection coll = new DataToWriteCollection();
            coll.WriteStuffNow();

            initialStuff = new DataProvider();
         

           
            CoreSetup setup = new CoreSetup(initialStuff);
            UnitsSetup unitSetup = new UnitsSetup(initialStuff);

            //Console.WriteLine(initialStuff.);

            setup.EingabeGameMode();
            setup.EingabeGrandAlliance();
            setup.EingabeFaction();
            setup.EingabeSubfaction();

            unitSetup.UnitSetup();

            
        }

    }
}
