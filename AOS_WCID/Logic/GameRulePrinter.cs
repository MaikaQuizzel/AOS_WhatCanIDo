using AOS_WCID.Data;
using AOS_WCID.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Logic
{
    public class GameRulePrinter
    {
        private int totalPoints = 0;
        private SpecialWordsComparator specialWordsComparator = new SpecialWordsComparator();   
        private StringBuilder stringBuilder = new StringBuilder();

        public GameRulePrinter()
        {
        }
        public void CreateFile()
        {
            AddPoints();
            stringBuilder.Append("Gamemode: ");
            stringBuilder.Append(PlayerPicks.Instance.GameName);
            stringBuilder.Append('\n');

            stringBuilder.Append("Points: ");
            stringBuilder.Append(totalPoints);
            stringBuilder.Append('\n');

            stringBuilder.Append("Faction: ");
            stringBuilder.Append(PlayerPicks.Instance.Faction);
            stringBuilder.Append('\n');

            stringBuilder.Append("Subfaction: ");
            stringBuilder.Append(PlayerPicks.Instance.Subfaction);
            if (PlayerPicks.Instance.Subfaction.Name == StringConstants.NOSUBFACTION)
            {
                foreach (TenetAbility tenetAbility in PlayerPicks.Instance.TenetAbilities)
                {
                    stringBuilder.Append(" ").Append(tenetAbility.Name);
                }

            }
            stringBuilder.Append('\n');

            stringBuilder.Append("Batellion: ");
            stringBuilder.Append(PlayerPicks.Instance.Batallion.Name);
            stringBuilder.Append('\n');

            string path=""

            WritePhases();
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(stringBuilder);
            }

        }
        private void AddPoints()
        {
            int heroList = PlayerPicks.Instance.HeroList.Count();
            int endlessSpellList = PlayerPicks.Instance.EndlessSpellList.Count();
            int unitList = PlayerPicks.Instance.UnitsList.Count();
            for (int i = 0; i < heroList; i++)
            {
                totalPoints += PlayerPicks.Instance.HeroList[i].Points();
            }
            for (int i = 0; i < endlessSpellList; i++)
            {
                totalPoints += PlayerPicks.Instance.EndlessSpellList[i].Points;
            }
            for (int i = 0; i < unitList; i++)
            {
                totalPoints += PlayerPicks.Instance.UnitsList[i].Points();
            }
        }
        private void WritePhases()
        {
            HeroPhase();
            MovementPhase();
            ShootingPhase();
            ChargePhase();
            CombatPhase();
            BattleshockPhase();
        }
        private void HeroPhase() {
            stringBuilder.AppendLine("Hero Phase");
            stringBuilder.Append("\n");

            foreach (Hero hero in PlayerPicks.Instance.HeroList)
            {
                stringBuilder.AppendLine($"{hero.Name}: ");
                foreach (String ability in hero.Abilities())
                {
                    if(SpecialWordsComparator.CompareAbilitiyToList(ability, StringConstants.HEROPHASE))
                    {
                        stringBuilder.Append("\t").Append(ability);
                    }
                }
                foreach (Artefact artefact in PlayerPicks.Instance.ArtefactList)
                {
                    if (artefact.Owner == hero)
                    {
                        if (SpecialWordsComparator.CompareAbilitiyToList(artefact.Description, StringConstants.HEROPHASE))
                        {
                            stringBuilder.Append("\t").Append(artefact.Name).Append(": ").Append(artefact.Description);
                        }
                    }
                }
            }

        }
        private void MovementPhase()
        {
            stringBuilder.AppendLine("Movement Phase");
            stringBuilder.Append("\n");

            foreach (Hero hero in PlayerPicks.Instance.HeroList)
            {
                stringBuilder.AppendLine($"{hero.Name}: ");
                foreach (string ability in hero.Abilities())
                {
                    if (SpecialWordsComparator.CompareAbilitiyToList(ability, StringConstants.MOVEMENTPHASE))
                    {
                        stringBuilder.Append("\t").Append(ability);
                    }
                }
                foreach(Artefact artefact in PlayerPicks.Instance.ArtefactList)
                {
                    if(artefact.Owner == hero)
                    {
                        if(SpecialWordsComparator.CompareAbilitiyToList(artefact.Description, StringConstants.MOVEMENTPHASE)){
                            stringBuilder.Append("\t").Append(artefact.Name).Append(": ").Append(artefact.Description);
                        }
                    }
                }
            }

            stringBuilder.AppendLine();
            foreach(Units unit in PlayerPicks.Instance.UnitsList)
            {
                stringBuilder.AppendLine($"{unit.Name}: ");
                foreach(string ability in unit.Abilities())
                {
                    if (SpecialWordsComparator.CompareAbilitiyToList(ability, StringConstants.MOVEMENTPHASE))
                    {
                        stringBuilder.Append("\t").Append(ability);
                    }
                }
            }
            stringBuilder.AppendLine();
            foreach (EndlessSpell unit in PlayerPicks.Instance.EndlessSpellList)
            {
                stringBuilder.AppendLine($"{unit.Name}: ");
                foreach (string ability in unit.Abilities())
                {
                    if (SpecialWordsComparator.CompareAbilitiyToList(ability, StringConstants.MOVEMENTPHASE))
                    {
                        stringBuilder.Append("\t").Append(ability);
                    }
                }
            }
        }
        private void ShootingPhase() { 
            
        }
        private void ChargePhase()
        {

        }
        private void CombatPhase() { }
        private void BattleshockPhase() { }
        
    }
}
