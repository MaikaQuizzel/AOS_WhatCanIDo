using AOS_WCID.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Logic
{
    public  class SpecialWordsComparator
    {
        private List<string> wordsHeroPhase;
        private List<string> wordsMovmentPhase;
        private List<string> wordsChargePhase;
        private List<string> wordsShootingPhase;
        private List<string> wordsCombatPhase;
        private List<string> wordsBattleshockPhase;

        public SpecialWordsComparator() 
        {

        }

        public bool CompareAbilitiyToList(string ability, string phase) 
        {
            var listToCompare = new List<string>();
            if(phase == StringConstants.HEROPHASE)
            {
                listToCompare.AddRange(wordsHeroPhase);
            }

            if (phase == StringConstants.MOVEMENTPHASE)
            {
                listToCompare.AddRange(wordsMovmentPhase);
            }

            if (phase == StringConstants.CHARGEPHASE)
            {
                listToCompare.AddRange(wordsChargePhase);
            }

            if (phase == StringConstants.SHOOTINGPHASE)
            {
                listToCompare.AddRange(wordsShootingPhase);
            }

            if(phase == StringConstants.COMBATPHASE)
            {
                listToCompare.AddRange(wordsCombatPhase);
            }

            if (phase == StringConstants.BATTLESHOCKPHASE)
            {
                listToCompare.AddRange(wordsBattleshockPhase);
            }
            return false;    
        }
        private void InitWordLists()
        {

        }
    }
}
