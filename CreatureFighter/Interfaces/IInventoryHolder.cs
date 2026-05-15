using CreatureFighter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureFighter.Interfaces
{
    internal interface IInventoryHolder
    {
        List<Item> Inventory { get; }
        string InventoryList();
    }
}
