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
    public class SelectTenet : InputValidator, ICoreSelection
    {
        private StringBuilder consoleText = new StringBuilder();
        private DataProvider? dataProvider;

        public void GenerateConsoleText()
        {
            consoleText.AppendLine(PlayerPicks.Instance.Tenets.Count() == 0 ? "What is your first Tenat?" : "What is your second Tenat?");
        }

        public void ReadValidInput()
        {
            RemoveTenetOnFirstSelect();

            int tenetID = -1;

            int tenetCount = dataProvider.TenetList.Count();
            bool isValidTenet = false;

            while (!isValidTenet)
            {
                Console.WriteLine(consoleText.ToString());
                for (int i = 0; i < tenetCount; i++)
                {
                    Console.WriteLine($"{i} for {dataProvider.TenetList[i].Name}");
                }
                isValidTenet = IsValidInput(tenetCount, out tenetID);
            }
            PlayerPicks.Instance.Tenets.Add(dataProvider.TenetList[tenetID]);
            ConsoleSpacer.PrintSpacer();
        }

        public SelectTenet()
        {
            dataProvider = new DataProvider(new DataToWriteCollection());
        }

        private void RemoveTenetOnFirstSelect()
        {
            if(PlayerPicks.Instance.Tenets.Count >= 1)
            { 
                Tenets? test = dataProvider.TenetList.FirstOrDefault(t => t.Name == PlayerPicks.Instance.Tenets[0].Name);

                if (test == null)
                    throw new NullReferenceException();

                dataProvider.TenetList.Remove(test);
            }

        }

    }


}
