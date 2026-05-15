using CreatureFighter.Models;

namespace CreatureFighter.Factories
{
    public static class AdventurerFactory
    {
        //Metoda statyczna
        public static Adventurer Create()
        {
            // 🔹 pobranie imienia
            Console.Write("Podaj imię postaci: ");
            string name = Console.ReadLine();

            // 🔹 wybór klasy
            string choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Wybierz klasę:");
                Console.WriteLine("1 - Warrior (lekki wojownik)");
                Console.WriteLine("2 - Archer (łucznik)");

                choice = Console.ReadLine();

            } while (choice != "1" && choice != "2");

            // 🔹 stworzenie odpowiedniej klasy
            Adventurer character;

            if (choice == "1")
            {
                character = new Warrior(name);
            }
            else
            {
                character = new Archer(name);
            }
            return character;
        }
    }
}