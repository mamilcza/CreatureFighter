using CreatureFighter.Interfaces;

namespace CreatureFighter.Models
{
    internal class Wall : IWorldObject
    {
        public string Name { get; }
        public string Interaction { get; } = "Uderzyłeś się w głowę.";
        public Wall( string name)
        {
            this.Name = name;
        }
        public string OnLeftClick()
        {
            return $"To jest {Name}. Przejścia nie ma";
        }
        public string OnRightClick()
        {
            return Interaction;
        }
    }
}
