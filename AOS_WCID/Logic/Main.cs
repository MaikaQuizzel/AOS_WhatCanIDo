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
        private InitialStuff initialStuff;


        public void StartGame()
        {
            initialStuff = new InitialStuff();
            initialStuff.InitializeStuff();

            playerPick = new PlayerPicks();
            CoreSetup setup = new CoreSetup(playerPick, initialStuff);


            setup.EingabeGameMode();
            setup.EingabeGrandAlliance();
            setup.EingabeFaction();
            setup.EingabeSubfaction();
        }


        
        public void EingabeBattallion()
        {
            //wähle eine Battallion aus
        }
        public void EingabeGeneral()
        {
            //wähle Hero als General
            // HeroPick()
            //wähle CommandTrait
            // wähle Artefact
            //wähle spell
        }
        public void EingabeUnits()
        {
            bool auswahlFertig = false;
            while (!auswahlFertig)
            {
                //HeroPick()
                //BattlelinePick
            }
        }
        public Unit HeroPick() { return null; }
        public Unit BattlelinePick() { return null; }
        public Unit AttelleryPick() { return null; }
        public EndlessSpell EndlessSpellPick() { return null; }
        public Unit OtherPick() { return null; }


        public Ability AuswahlAbility()
        {
            return null;
        }
        public CommandTrait AuswahlCommandTrait()
        {
            return null;
        }
        public Artefact AuswahlArtefact()
        {
            return null;
        }
        public Spell AuswahlSpell()
        {
            return null;
        }
    }
}
