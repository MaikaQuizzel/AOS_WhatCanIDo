using AOS_WCID.Konsole;

namespace WCID_UnitTests.Mock
{
    public class TestConsoleReader : ConsolenReader
    {
        public string ConsoleText { get; set; }
        public override string GetLine()
        {
            return ConsoleText;
        }

    }
}
