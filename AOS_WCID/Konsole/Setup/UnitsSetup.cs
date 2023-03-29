using AOS_WCID.Data;
using AOS_WCID.Entities;
using AOS_WCID.Logic;
using System.Text;

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
            HeroPick(true);
            //wähle CommandTrait
            AuswahlCommandTrait();
            // wähle Artefact
            AuswahlArtefact();
            //wähle spell
            if (playerPick.HeroList.First().Keywords().Contains("WIZARD"))
            {
                AuswahlSpell();
            }
            if (playerPick.HeroList.First().Keywords().Contains(""))
            {

            }
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
        public void HeroPick(bool isGeneralPick) 
        {
            chooseText.Clear();
            chooseText.AppendLine("Wähle dein ");
            if (isGeneralPick)
            {
                chooseText.Append(playerPick.GameName.Equals(StringConstants.GAMEMODEPATH) ? "Kriegsherr" : "General");
            }
            if (!isGeneralPick)
            {
                chooseText.Append("Helden");
            }
            

            int heroID = -1;
            bool isValidGeneral = false;
            int heroListCount = 0;
            if (playerPick.GameName.Equals(StringConstants.GAMEMODEPATH)&& isGeneralPick)
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
           else{
                heroListCount = initialStuff.HeroList.Count();
            }
            while (!isValidGeneral)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < heroListCount; i++)
                {   

                    if (isGeneralPick)
                    {
                        if (playerPick.GameName.Equals(StringConstants.GAMEMODEPATH))
                        {
                            //PTG Warlord
                            if (!initialStuff.HeroList[i].Keywords().Contains("UNIQUE"))
                            {
                                Console.WriteLine($"{i} für  {initialStuff.HeroList[i].Name}");
                            }
                        }
                        else
                        {
                            //General
                            Console.WriteLine($"{i} für  {initialStuff.HeroList[i].Name}");
                        }
                    }
                    else
                    {
                        //normaler Hero in liste
                        Console.WriteLine($"{i} für  {initialStuff.HeroList[i].Name}");
                    }
                    
                }

                isValidGeneral = IsValidInput(heroListCount,out heroID);

                playerPick.HeroList.Add(initialStuff.HeroList[heroID]);
            }
        }
        public void BattlelinePick() {  }
        public void AttelleryPick() {  }
        public void EndlessSpellPick() {  }
        public void OtherPick() {  }


        public void AuswahlAbility()
        {
           
        }
        public void AuswahlCommandTrait()
        {
            int commandTraitID = -1;
            int commandTraitListCount = initialStuff.CommandTraitList.Count();
            bool isValidID = false;

            chooseText.Clear();
            chooseText.AppendLine($"Choose your command trait for {playerPick.HeroList.First().Name}");

            while (!isValidID)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < commandTraitListCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.CommandTraitList[i].Name}");
                }
                isValidID = IsValidInput(commandTraitListCount, out commandTraitID);
            }
            playerPick.CommandTrait = initialStuff.CommandTraitList[commandTraitID];
            chooseText.Clear();
            
        }
        public void AuswahlArtefact()
        {
            int artefactID = -1;
            int artefactListCount = initialStuff.ArtefactList.Count();
            bool isValidID = false;

            chooseText.Clear();
            chooseText.AppendLine($"Choose your Artefacts.");
            while (!isValidID)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < artefactListCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.ArtefactList[i].Name}");
                }
                isValidID = IsValidInput(artefactListCount, out artefactID);
            }
            playerPick.ArtefactList.Add(initialStuff.ArtefactList[artefactID]);
            chooseText.Clear();
        }
        public void AuswahlSpell()
        {
            int spellID = -1;
            int spellListCount = initialStuff.SpellList.Count();
            bool isValidID = false;

            chooseText.Clear();
            chooseText.AppendLine("Choose a Spell");

            while (!isValidID)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < spellListCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.SpellList[i].Name}");
                }
                isValidID = IsValidInput(spellListCount, out spellID);
            }
            playerPick.SpellList.Add(initialStuff.SpellList[spellID]);
            chooseText.Clear();
        }
        public void PickPrayer()
        {
            int prayerID = -1;

        }
    }
}
