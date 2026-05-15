using CreatureFighter.Factories;
using CreatureFighter.Interfaces;
using CreatureFighter.UI;

namespace CreatureFighter.Models
{
    public class Game
    {
        //delegate/event
        public event Action<string> OnMessage;
        public void SendMessage(string message)
        {
            OnMessage?.Invoke(message);
        }


        public void Run()
        {
            this.Run(new ConsoleDisplay());
        }
        public void Run(IDisplay display)
        {
            SendMessage("Start gry");
            Adventurer hero = AdventurerFactory.Create();
            Npc andrzej = new Npc("Andrzej");
            List<IClickable> worldEntities = new List<IClickable>();
            worldEntities.Add(hero);
            worldEntities.Add(andrzej);
            worldEntities.AddRange(CreateWorld());


            int i = 1;
            foreach (var entity in worldEntities)
            {
                display.Display("####################");
                display.Display($"Spotkanie nr {i}");
                display.Display("====================");
                display.Display(entity.Name);
                display.Display("====================");
                display.Display(entity.OnLeftClick());
                display.Display("--------------------");
                display.Display(entity.OnRightClick());

                i++;
            }
            SendMessage("####################\n" +
                "Koniec gry!");

        }
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
