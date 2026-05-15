using CreatureFighter.Interfaces;
using CreatureFighter.Models;

namespace CreatureFighter.Actors
{
    public abstract partial class Adventurer : Creature, IInventoryHolder
    {
        public override string OnLeftClick()
        {
            return $"Statsy {Name} - {GetType().Name} [{Stats.ToString()}]\n"
                + Say(BattleCry);
        }
        public override string OnRightClick()
        {
            return InventoryList();
        }

        public string InventoryList()
        {
            if (!Inventory.Any())
            {
                return $"{Name}: nie ma przedmiotów w ekwipunku";
            }

            var lines = new[] { $"{Name} ma w ekwipunku:" }
                .Concat(Inventory.Select(item => $"- {item.Name}"));

            return string.Join("\n", lines);
        }

        public virtual string Say(string message)
        {
            return $"{Name}: {message}";
        }
        // ✅ dodawanie itemu
        protected void AddItem(string name)
        {
            Inventory.Add(new Item(name));
        }
        public string MusclePose()
        {
            return $"{Name} pokazuje muskuły.";
        }
        public string PotionJuggle()
        {
            return $"{Name} żongluje miksturami.";
        }
        public string CancanDance()
        {
            return $"{Name} tańczy cancana.";
        }

    }
}
