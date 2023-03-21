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
        private PlayerPicks playerPick;
        private DataProvider initialStuff;


        public void StartGame()
        {
            initialStuff = new DataProvider();
            initialStuff.InitializeStuff();

            playerPick = new PlayerPicks();
            CoreSetup setup = new CoreSetup(playerPick, initialStuff);
            UnitsSetup unitSetup = new UnitsSetup(playerPick, initialStuff);


            setup.EingabeGameMode();
            setup.EingabeGrandAlliance();
            setup.EingabeFaction();
            setup.EingabeSubfaction();

            unitSetup.EingabeBattallion();

            
        }

    }
}
