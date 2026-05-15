using CreatureFighter.Interfaces;
using CreatureFighter.Models;

namespace CreatureFighter.Game
{
    public partial class Game
    {
        private List<IClickable> CreateWorld()
        {
            Item coins10k = new Item("10k golda");

            var items = new List<Item>
            {
                new Item("100k gold"),
                new Item("Order wypróżnienia")
            };

            return new List<IClickable>
            {
                new Chest("Drewniana skrzynia"),
                new Rock("Mały kamyk"),
                new Wall("Ściana z desek"),

                new Chest("Stalowa skrzynia", coins10k),
                new Rock("Kamień"),
                new Wall("Ściana ze skały"),

                new Chest("Złota skrzynia", items),
                new Rock("Kamień wagi wielkiej"),
                new Wall("Ściana z cegieł")
            };
        }
    }

}
