using CreatureFighter.Models;

namespace CreatureFighter.Actors
{
    public class Archer : Adventurer
    {
        public override string BattleCry => "Zawsze trafiam w cel!";

        public Archer(string name) : base(name)
        {
            Stats.Plus(health: 0, strength: 0, dexterity: 2);
            Stats.Minus(health: 0, strength: 2, dexterity: 0);
            AddStarterItems();
        }

        private void AddStarterItems()
        {
            AddItem("Krótki Łuk");
            AddItem("Płaszcz z kapturem"); // przeszywanica
        }
    }
}
