using CreatureFighter.Interfaces;
using CreatureFighter.Models;

namespace CreatureFighter.Actors
{
    public abstract partial class Adventurer : Creature, IInventoryHolder
    {
        public virtual string BattleCry { get; set; }
        public Stats Stats { get; private set; }
        public List<Item> Inventory { get; set; } = new List<Item>();

        protected Adventurer(string name) : base(name)
        {
            Name = name;
            Stats = new Stats();
            Console.WriteLine("Base Stats:");
            Console.WriteLine(Stats.ToString());
        }
    }
}
