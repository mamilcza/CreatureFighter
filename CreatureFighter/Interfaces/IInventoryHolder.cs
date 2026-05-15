using CreatureFighter.Models;

namespace CreatureFighter.Interfaces
{
    internal interface IInventoryHolder
    {
        List<Item> Inventory { get; }
        string InventoryList();
    }
}
