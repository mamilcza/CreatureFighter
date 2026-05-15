using CreatureFighter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureFighter.Models
{
    public abstract class Creature : ICreature
    {
        public string Name { get; protected set; }
        protected Creature(string name)
        {
            this.Name = name;
        }

        public virtual string Say(string message)
        {
            return $"{Name}: {message}";
        }

        public abstract string OnLeftClick();
        public abstract string OnRightClick();

    }
}
