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
using AOS_WCID.Konsole.Setup.Core;

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

            initialStuff = new DataProvider(coll);

            CoreSetup setup = new CoreSetup(initialStuff);
            setup.RunSetup();

            UnitsSetup unitSetup = new UnitsSetup(initialStuff);
            unitSetup.UnitSetup();
            GameRulePrinter printer = new GameRulePrinter();
            printer.CreateFile();
        }

    }
}
