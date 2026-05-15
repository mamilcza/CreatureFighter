using CreatureFighter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
