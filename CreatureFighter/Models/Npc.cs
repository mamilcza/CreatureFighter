using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureFighter.Models
{
    public class Npc : Creature
    {
        public string Name { get; private set; }
        public override string OnLeftClick()
        {
            return $"{Name} wygląda na dobrego człowieka.";
        }
        public override string OnRightClick()
        {
            return Say($"Witaj! Mam na imię {Name}");
        }


        public Npc(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
