using CreatureFighter.Models;

namespace CreatureFighter.Actors
{
    public class Warrior : Adventurer
    {
        public override string BattleCry => "To ja go tnę!";
        public Warrior(string name) : base(name)
        {
            Stats.Plus(health:10, strength:2, dexterity:0);
            Stats.Minus(health: 0, strength: 0, dexterity: 2);
            AddStarterItems();
        }

        private void AddStarterItems()
        {
            AddItem("Krótki miecz");
            AddItem("Przeszywanica");
        }
    }
}
