using CreatureFighter.UI;

namespace CreatureFighter.Game
{
    public partial class Game
    {
        //event
        public event Action<string> OnMessage;
        public void SendMessage(string message)
        {
            OnMessage?.Invoke(message);
        }
        public void Run()
        {
            Run(new ConsoleDisplay());
        }
        //delegate
        public delegate string SpecialTrick();
    }
}
