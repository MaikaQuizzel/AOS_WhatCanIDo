using AOS_WCID.Konsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Data
{
    public abstract class InputValidator
    {
        public ConsolenReader consolenReader = new ConsolenReader();
      
        public bool IsValidInput(List<int> allowedInts, out int value)
        {
            string input = consolenReader.GetLine();

            value = -1;

            if (string.IsNullOrEmpty(input) || !input.All(Char.IsDigit))
                return false;
            

            if (!allowedInts.Contains(Int32.Parse(input))) 
                return false;

            value = Int32.Parse(input);
            return true;
        }

        public bool IsValidInput(List<string> texts)
        {
            string input = consolenReader.GetLine();

            return texts.Contains(input);
        }
    }
}
