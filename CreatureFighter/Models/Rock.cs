using CreatureFighter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
