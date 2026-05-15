using CreatureFighter.Actors;
using CreatureFighter.Factories;
using CreatureFighter.Interfaces;
using CreatureFighter.Models;

namespace CreatureFighter.Game
{
    public partial class Game
    {
        public void Run(IDisplay display)
        {
            SendMessage("Start gry");
            Adventurer hero = AdventurerFactory.Create();
            Npc andrzej = new Npc("Andrzej");
            List<IClickable> worldEntities = new List<IClickable>();
            worldEntities.Add(hero);
            worldEntities.Add(andrzej);
            worldEntities.AddRange(CreateWorld());

            //delegate
            SpecialTrick specialTrick;

            if (hero.Stats.Strength > hero.Stats.Dexterity)
            {
                specialTrick = hero.MusclePose;
            }
            else if (hero.Stats.Strength < hero.Stats.Dexterity)
            {
                specialTrick = hero.PotionJuggle;
            }
            else
            {
                specialTrick = hero.CancanDance;
            }

            display.Display("====================");
            display.Display(specialTrick());
            display.Display("====================");

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
            display.Display("====================");
            display.Display(specialTrick());
            display.Display("====================");

            SendMessage("####################\n" +
                "Koniec gry!");
        }
    }
}
