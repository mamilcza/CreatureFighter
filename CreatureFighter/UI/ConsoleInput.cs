using CreatureFighter.Interfaces;

namespace CreatureFighter.UI
{
    public class ConsoleInput : IInput
    {
        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
