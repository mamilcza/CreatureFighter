// See https://aka.ms/new-console-template for more information
using CreatureFighter.Game;
using CreatureFighter.UI;

class Program
{
    static void Main()
    {
        var display = new ConsoleDisplay();
        var input = new ConsoleInput();
        var consoleGame = new Game();

        consoleGame.OnMessage += display.Display;

        do consoleGame.Run(input, display);
        while (true);
    }
}