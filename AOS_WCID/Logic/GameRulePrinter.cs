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
        public GameRulePrinter() 
        {
        }
        public void CreateFile()
        {

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
        private void HeroPhase() { }
        private void MovementPhase()
        {

        }
        private void ShootingPhase() { }
        private void ChargePhase()
        {

        }
        private void CombatPhase() { }
        private void BattleshockPhase() { }
    }
}
