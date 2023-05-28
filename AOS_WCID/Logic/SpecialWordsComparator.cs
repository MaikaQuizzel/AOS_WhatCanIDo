using AOS_WCID.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Logic
{
    public class SpecialWordsComparator
    {
        private static List<string> wordsHeroPhase = new List<string>() {
                "hero phase",
                "casting value"
            };
        private static List<string> wordsMovmentPhase = new List<string>() {
                "set up",
                "reserve",
                "movement phase"
            };
        private static List<string> wordsChargePhase = new List<string>() {
                "charge move",
                "casting value"
            };
        private static List<string> wordsShootingPhase = new List<string>() {
                "aim",
                "ward",
                "shooting phase",
                "save roll"
            };
        private static List<string> wordsCombatPhase = new List<string>() {
                "ward",
                "casting value",
                "make a hit",
                "save roll"
            };
        private static List<string> wordsBattleshockPhase = new List<string>() {
                "battleshock test"
            };

        public SpecialWordsComparator() 
        {
        }

        public static bool CompareAbilitiyToList(string ability, string phase) 
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
            foreach(string word in listToCompare)
            {
                if (ability.Contains(word))
                {
                    return true;
                }
            }
            return false;    
        }

    }
}
