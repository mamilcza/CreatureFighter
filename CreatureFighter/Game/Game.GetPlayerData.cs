using CreatureFighter.Interfaces;
using CreatureFighter.UI;

namespace CreatureFighter.Game
{
    public partial class Game
    {
        public (string name, string type) GetPlayerData(IInput input)
        {
            bool isValid;
            var classMap = new Dictionary<string, string>
            {
                { "1", "warrior" },
                { "2", "archer" }
            };
            string name = input.GetInput("Podaj imię: ");
            string type;
            do
            {
                type = input.GetInput("Wybierz klasę (1-Warrior, 2-Archer): ");
                isValid = classMap.ContainsKey(type);
                if (!isValid)
                {
                    SendMessage("Nieprawidłowy wybór.");
                }

            } while (!isValid);

            return (name, classMap[type]);
        }
    }
}
