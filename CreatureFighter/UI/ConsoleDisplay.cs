using CreatureFighter.Interfaces;

namespace CreatureFighter.UI
{
    internal class ConsoleDisplay : IDisplay
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }

    }
}
