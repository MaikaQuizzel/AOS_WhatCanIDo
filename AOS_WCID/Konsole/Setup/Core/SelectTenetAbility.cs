using AOS_WCID.Data;
using AOS_WCID.Entities;
using AOS_WCID.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup.Core
{
    public class SelectTenetAbility : InputValidator, ICoreSelection
    {
        private StringBuilder consoleText = new StringBuilder();

        public void GenerateConsoleText()
        {
            consoleText.AppendLine(PlayerPicks.Instance.TenetAbilities.Count() == 0 ? "What is your first ability?" : "What is your second ability?");
        }

        public void ReadValidInput()
        {
            Tenets currentTenet = PlayerPicks.Instance.Tenets.Last();
            int tenetAbilityID = -1;

            bool isValidAbilityId = false;

            while (!isValidAbilityId)
            {
                Console.WriteLine(consoleText.ToString());
                for (int i = 0; i < currentTenet.Abilities.Count(); i++)
                {
                    Console.WriteLine($"{i} for {currentTenet.Abilities[i].Name}");
                }

                isValidAbilityId = IsValidInput(currentTenet.Abilities.Count, out tenetAbilityID);

                if (isValidAbilityId)
                {
                    PlayerPicks.Instance.TenetAbilities.Add(currentTenet.Abilities[tenetAbilityID]);
                }
            }
            ConsoleSpacer.PrintSpacer();
        }

        public SelectTenetAbility() { }
    }
}
