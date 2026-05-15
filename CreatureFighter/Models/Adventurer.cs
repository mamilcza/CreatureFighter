using CreatureFighter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureFighter.Models
{
    public abstract class Adventurer : Creature, IInventoryHolder
    {
        public virtual string BattleCry { get; set; }
        protected Stats Stats { get; private set; }
        public List<Item> Inventory { get; set; } = new List<Item>();

        protected Adventurer(string name) : base(name)
        {
            this.Name = name;
            this.Stats = new Stats();
            Console.WriteLine("Base Stats:");
            Console.WriteLine(Stats.ToString());
        }
        public override string OnLeftClick()
        {
            return $"Statsy {Name} - {this.GetType().Name} [{Stats.ToString()}]\n"
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
    }
}
