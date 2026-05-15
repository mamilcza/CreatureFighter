using CreatureFighter.Interfaces;

namespace CreatureFighter.Models
{
    internal class Chest : IWorldObject, IInventoryHolder
    {
        public string Name { get; }
        public List<Item> Inventory { get; } = new List<Item>();
        public string Interaction { get; } = "Otwierasz i patrzysz do środka.";
        public Chest(string name)
        {
            this.Name = name;
        }
        public Chest(string name, Item item) : this(name)
        {
            this.Inventory.Add(item);
        }
        public Chest(string name, List<Item> items) : this(name)
        {
            this.Inventory = new List<Item>(items); ;
        }


        public string OnLeftClick()
        {
            return $"To jest {Name}. Zapewne pełna przedmiotów.";
        }
        public string OnRightClick()
        {
            return $"{Interaction}\r\n" +
                $"{InventoryList()}";
        }

        public string InventoryList()
        {
            if (!Inventory.Any())
            {
                return $"{Name}: brak przedmiotów";
            }

            var lines = new[] { $"{Name} zawiera:" }
                .Concat(Inventory.Select(item => $"- {item.Name}"));

            return string.Join("\n", lines);
        }
    }
}
