using CreatureFighter.Interfaces;

namespace CreatureFighter.Models
{
    public class Item : INamed
    {
        public string Name { get; }

        public Item(string name)
        {
            Name = name;
        }
    }
}
