using CreatureFighter.Interfaces;

namespace CreatureFighter.Models
{
    internal class Rock : IWorldObject
    {
        public string Name { get; }
        public string Interaction { get; } = "Potknąłeś się.";
        public Rock(string name)
        {
            this.Name = name;
        }
        public string OnLeftClick()
        {
            return $"To jest {Name}. Leży tu sobie.";
        }
        public string OnRightClick()
        { 
            return Interaction;
        }
    }
}
