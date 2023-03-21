using AOS_WCID.Konsole;

namespace WCID_UnitTests
{
    internal class TestConsoleReader : ConsolenReader
    {
        public override string GetLine()
        {
            return "Ich bin die Eingabe!";
        }
    }
}
