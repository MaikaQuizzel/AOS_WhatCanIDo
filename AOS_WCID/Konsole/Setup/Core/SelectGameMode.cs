using AOS_WCID.Data;
using AOS_WCID.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Konsole.Setup.Core
{
    public class SelectGameMode : InputValidator, ICoreSelection
    {
        private StringBuilder consoleText = new StringBuilder();

        public SelectGameMode()
        {

        }

        public void GenerateConsoleText()
        {
            consoleText.Append("Which Gamemode do you want to play?");
            consoleText.AppendLine("\n 0 for Path to Glory \n 1 for normal");
        }

        public void ReadValidInput()
        {
            int gameMode = -1;

            while (gameMode != 0 && gameMode != 1)
            {
                Console.WriteLine(consoleText.ToString());

                IsValidInput(new List<int> { 0, 1 }, out gameMode);

                if (gameMode == 0 || gameMode == 1)
                {
                    PlayerPicks.Instance.GameName = gameMode == 0 ? StringConstants.GAMEMODEPATH : "Normal";
                    Console.WriteLine($"You picked {PlayerPicks.Instance.GameName}.");
                    continue;
                }
                Console.WriteLine("Enter \" 0\" or \" 1\" ");
            }
            ConsoleSpacer.PrintSpacer();
        }

        //public void EingabeGameMode()
        //{
        //    //StringBuilder chooseText = new StringBuilder();
        //    //chooseText.Append("Which Gamemode do you want to play?");
        //    //chooseText.AppendLine("\n 0 for Path to Glory \n 1 for normal");

        //    //int gameMode = -1;

        //    //while (gameMode != 0 && gameMode != 1)
        //    //{
        //    //    Console.WriteLine(chooseText.ToString());

        //    //    IsValidInput(new List<int> { 0, 1 }, out gameMode);

        //    //    if (gameMode == 0 || gameMode == 1)
        //    //    {
        //    //        PlayerPicks.Instance.GameName = gameMode == 0 ? StringConstants.GAMEMODEPATH : "Normal";
        //    //        Console.WriteLine($"You picked {PlayerPicks.Instance.GameName}.");
        //    //        continue;
        //    //    }
        //    //    Console.WriteLine("Enter \" 0\" or \" 1\" ");
        //    //}
        //    //ConsoleSpacer.PrintSpacer();
        //}

    }
}
