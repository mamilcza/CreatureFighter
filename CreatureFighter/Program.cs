// See https://aka.ms/new-console-template for more information
using CreatureFighter.Models;
using CreatureFighter.UI;

class Program
{
    static void Main()
    {
        var display = new ConsoleDisplay();
        var consoleGame = new Game();

        consoleGame.OnMessage += display.Display;

        consoleGame.Run(display);
    }
}