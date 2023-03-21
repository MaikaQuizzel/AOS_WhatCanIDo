using AOS_WCID.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup
{
    public class UnitsSetup
    {
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
