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
            chooseText.AppendLine("Which Battalion you want to play?");

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
            HeroPick(true);
            AuswahlCommandTrait();
        }
        public void EingabeUnits()
        {
            bool auswahlFertig = false;
            chooseText.Clear();
            chooseText.AppendLine("What do you want to add?");
            chooseText.AppendLine("1 for hero");
            chooseText.AppendLine("2 for battleline");
            chooseText.AppendLine("3 for attelery");
            chooseText.AppendLine("4 for  endless spell");
            chooseText.AppendLine("5 for other");
            chooseText.AppendLine("f for finish");
            
            ConsolenReader reader = new ConsolenReader();
            string userinput = reader.GetLine();
            int userInt;
            while (!auswahlFertig)
            {
                Console.WriteLine(chooseText.ToString());

                if (userinput.Equals("f"))
                {
                    auswahlFertig = true;
                    return;
                }
                if(int.TryParse(userinput, out userInt))
                {
                    if (userInt ==1)
                    {
                        HeroPick(false);
                        continue;
                    }
                    if (userInt == 2)
                    {
                        BattlelinePick();
                        continue;
                    }
                    if (userInt == 3)
                    {
                        ArtelleryPick();
                        continue;
                    }
                    if (userInt == 4)
                    {
                        EndlessSpellPick();
                        continue;
                    }
                    if (userInt == 5)
                    {
                        OtherPick();
                        continue;
                    }
                }
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
                for (int i = 0; i < initialStuff.HeroList.Heros.Count(); i++)
                {
                    if (!initialStuff.HeroList.Heros[i].Keywords.Contains("UNIQUE"))
                    {
                        nonUniqueHerosCounter++;
                    }
                }
                heroListCount = nonUniqueHerosCounter;
            }
           else{
                heroListCount = initialStuff.HeroList.Heros.Count();
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
                            if (!initialStuff.HeroList.Heros[i].Keywords.Contains("UNIQUE"))
                            {
                                Console.WriteLine($"{i} für  {initialStuff.HeroList.Heros[i].Name}");
                            }
                        }
                        else
                        {
                            //General
                            Console.WriteLine($"{i} für  {initialStuff.HeroList.Heros[i].Name}");
                        }
                    }
                    else
                    {
                        //normaler Hero in liste
                        Console.WriteLine($"{i} für  {initialStuff.HeroList.Heros[i].Name}");
                    }
                    
                }

                isValidGeneral = IsValidInput(heroListCount,out heroID);

                
            }
            playerPick.HeroList.Add(initialStuff.HeroList.Heros[heroID]);
            if (playerPick.HeroList.Last().Keywords.Contains("WIZARD"))
            {
                AuswahlSpell();
            }
            if (playerPick.HeroList.Last().Keywords.Contains(""))
            {
                PickPrayer();
            }
            AuswahlArtefact();
        }
        public void BattlelinePick() 
        {
            chooseText.Clear();
            chooseText.AppendLine("Which battleline would you like to add?");
            List<Units> battlelineList= new List<Units>();
            for (int i = 0; i < initialStuff.UnitsList.Unitss.Count(); i++)
            {
                if (initialStuff.UnitsList.Unitss[i].Keywords().Contains("BATTLELINE"))
                {
                    battlelineList.Add(initialStuff.UnitsList.Unitss[i]);
                }
            }
            int battlelineID = -1;
            int battlelineListCount = battlelineList.Count();
            bool isValidID = false;

            while (!isValidID)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < battlelineListCount; i++)
                {
                    Console.WriteLine($"{i} für {battlelineList[i]}");
                }
                isValidID = IsValidInput(battlelineListCount, out battlelineID);
            }
            playerPick.UnitsList.Add(battlelineList[battlelineID]);

        }
        public void ArtelleryPick() 
        {
            chooseText.Clear();
            chooseText.AppendLine("Which artillery wuld you like to add?");
            List<Units> attileryList = new List<Units>();
            for (int i = 0; i < initialStuff.UnitsList.Unitss.Count(); i++)
            {
                if (initialStuff.UnitsList.Unitss[i].Keywords().Contains("ARTILLARY"))
                {
                    attileryList.Add(initialStuff.UnitsList.Unitss[i]);
                }
            }
            int attileryID = -1;
            int attileryListCount = attileryList.Count();
            bool isValidID = false;

            while (!isValidID)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < attileryListCount; i++)
                {
                    Console.WriteLine($"{i} für {attileryList[i]}");
                }
                isValidID = IsValidInput(attileryListCount, out attileryID );
            }
            playerPick.UnitsList.Add(attileryList[attileryID]);
        }
        public void EndlessSpellPick() 
        {
            chooseText.AppendLine("Which endlessspell do you want to add?");

            int endlessSpellID = -1;
            int endlessSpellCount = initialStuff.EndlessSpellsList.EndlessSpells.Count();
            bool isValidID = false;

            while (!isValidID)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < endlessSpellCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.EndlessSpellsList.EndlessSpells[i]}");
                }
                isValidID = IsValidInput(endlessSpellCount, out endlessSpellID);
            }
            playerPick.EndlessSpellList.Add( initialStuff.EndlessSpellsList.EndlessSpells[endlessSpellID]);
        }
        public void OtherPick() 
        {
            chooseText.Clear();
            chooseText.AppendLine("Which unit would you like to add?");
            List<Units> otherlist = new List<Units>();
            for (int i = 0; i < initialStuff.UnitsList.Unitss.Count(); i++)
            {
                if (!initialStuff.UnitsList.Unitss[i].Keywords().Contains("BATTLELINE")&&!initialStuff.UnitsList.Unitss[i].Keywords().Contains("ARTILLARY"))
                {
                    otherlist.Add(initialStuff.UnitsList.Unitss[i]);
                }
            }
            int otherID = -1;
            int otherListCount = otherlist.Count();
            bool isValidID = false;

            while (!isValidID)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < otherListCount; i++)
                {
                    Console.WriteLine($"{i} für {otherlist[i]}");
                }
                isValidID = IsValidInput(otherListCount, out otherID);
            }
            playerPick.UnitsList.Add(otherlist[otherID]);
        }
        public void AuswahlCommandTrait()
        {
            int commandTraitID = -1;
            int commandTraitListCount = initialStuff.CommandTraitList.Count();
            bool isValidID = false;

            Hero hero;
            chooseText.Clear();
            if (playerPick.HeroList.Count()>1 && playerPick.GameName == StringConstants.GAMEMODEPATH)
            {
                    hero = playerPick.HeroList.Last();
            }
            else
            {
                hero = playerPick.HeroList.First();
            }
            chooseText.AppendLine($"Choose your command trait for {hero.Name}");
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
            playerPick.CommandTrait.Owner = hero;

            chooseText.Clear();
            
            chooseText.Clear();
            chooseText.AppendLine($"Choose your command trait for {hero.Name}");

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
            playerPick.CommandTrait.Owner = playerPick.HeroList.First();

            chooseText.Clear();
            
        }
        public void AuswahlArtefact()
        {
            int artefactID = -1;
            int artefactListCount = initialStuff.ArtefactList.Count();
            bool isValidID = false;
            Hero hero = playerPick.HeroList.Last();
            chooseText.Clear();
            chooseText.AppendLine($"Choose your Artefacts for {hero.Name}");
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
            playerPick.ArtefactList.Last().Owner = hero;
            chooseText.Clear();
        }
        public void AuswahlSpell()
        {
            int spellID = -1;
            int spellListCount = initialStuff.SpellList.Count();
            bool isValidID = false;
            Hero hero = playerPick.HeroList.Last();

            chooseText.Clear();
            chooseText.AppendLine($"Choose a Spell for {hero.Name}");

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
            playerPick.SpellList.Last().Owner = hero;
            chooseText.Clear();
        }
        public void PickPrayer()
        {
            int prayerID = -1;
            int prayerListCount = initialStuff.PrayerList.Count();
            bool isValidID = false;
            Hero hero = playerPick.HeroList.Last();

            chooseText.Clear();
            chooseText.AppendLine($"Choose a Prayer for {hero.Name}" );

            while (!isValidID)
            {
                Console.WriteLine(chooseText.ToString());
                for (int i = 0; i < prayerListCount; i++)
                {
                    Console.WriteLine($"{i} für {initialStuff.PrayerList[i].Name}");
                }
                isValidID = IsValidInput(prayerListCount, out prayerID);
            }
            playerPick.PrayerList.Add(initialStuff.PrayerList[prayerID]);
            playerPick.PrayerList.Last().Owner = hero;
            chooseText.Clear();
        }
    }
}
