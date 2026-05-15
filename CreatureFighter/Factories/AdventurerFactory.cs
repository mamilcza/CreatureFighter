using CreatureFighter.Actors;
using CreatureFighter.Interfaces;

namespace CreatureFighter.Factories
{
    public static class AdventurerFactory
    {
        //Metoda statyczna

        public static Adventurer Create(string name, string type)
        {
            return type switch
            {
                "warrior" => new Warrior(name),
                "archer" => new Archer(name),
                _ => throw new ArgumentException("Nieznany wybór")
            };
        }
    }
}