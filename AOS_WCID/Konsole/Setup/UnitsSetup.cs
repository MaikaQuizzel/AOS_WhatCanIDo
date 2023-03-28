using AOS_WCID.Data;
using AOS_WCID.Entities;
using AOS_WCID.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup
{
    public class UnitsSetup: InputValidator
    {
        StringBuilder chooseText = new StringBuilder();
        private PlayerPicks playerPick;
        private DataProvider initialStuff;

        public UnitsSetup(PlayerPicks playerPick, DataProvider initialStuff)
        {
            this.playerPick = playerPick;
            this.initialStuff = initialStuff;
        }

        public void EingabeBattallion()
        {
            chooseText.AppendLine("Welches Batallion willst du spielen?");

            int batallionID = -1;
            int batallionListCount = initialStuff.BatallionList.Count();
            bool isValidID = false;

            while (!isValidID)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < batallionListCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.BatallionList[i]}");
                }
                isValidID = IsValidInput(batallionListCount, out batallionID);
            }
            playerPick.Batallion = initialStuff.BatallionList[batallionID];
        }
        public void EingabeGeneral()
        {
            //wähle Hero als General
            var general = HeroPick();
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
        public Unit HeroPick() 
        {
            chooseText.Clear();
            chooseText.AppendLine("Wähle dein ");
            chooseText.Append(playerPick.GameName.Equals(StringConstants.GAMEMODEPATH) ? "Kriegsherr" : "General");

            int heroID = -1;
            bool isValidGeneral = false;
            int heroListCount = 0;
            if (playerPick.GameName.Equals(StringConstants.GAMEMODEPATH))
            {
                int nonUniqueHerosCounter = 0;
                for (int i = 0; i < initialStuff.HeroList.Count(); i++)
                {
                    if (!initialStuff.HeroList[i].Keywords().Contains("UNIQUE"))
                    {
                        nonUniqueHerosCounter++;
                    }
                }
                heroListCount = nonUniqueHerosCounter;
            }
            if (playerPick.GameName.Equals("Normal")){
                heroListCount = initialStuff.HeroList.Count();
            }
            while (!isValidGeneral)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < heroListCount; i++)
                {   
                    //PTG WarlordPick
                    if (playerPick.GameName.Equals(StringConstants.GAMEMODEPATH) && !initialStuff.HeroList[i].Keywords().Contains("UNIQUE"))
                    {
                        Console.WriteLine();
                    }
                    //Normal General Pick
                }
            }
            
            return null;
        }
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
